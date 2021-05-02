using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Project.Scripts
{
    public class PooledObjectsSpawner : MonoBehaviour
    {
        [SerializeField] private Vector3 spawnLocalPosition;
        [SerializeField] private List<Resetter> pool;

        public bool HasFreePooledObject => freePooledObjectCount > 0;
        private int freePooledObjectCount;


        private void Awake()
        {
            for (int i = 0; i < pool.Count; i++)
                TryPoolObject(pool[i]);
        }

        public void TryPoolObject(Resetter resetter)
        {
            if(!pool.Contains(resetter)) return;
            
            resetter.gameObject.SetActive(false);

            resetter.transform.localPosition = spawnLocalPosition;

            freePooledObjectCount++;
        }

        public void SpawnNextObject()
        {
            if (this.enabled && HasFreePooledObject)
            {
                Resetter resetter = pool.FirstOrDefault(resetter => resetter.gameObject.activeSelf == false);

                if (resetter != null)
                {
                    resetter.Reset();
                    resetter.gameObject.SetActive(true);

                    freePooledObjectCount--;
                }
            }
        }
    }
}