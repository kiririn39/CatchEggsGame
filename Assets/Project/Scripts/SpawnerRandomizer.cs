using System;
using System.Collections;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Project.Scripts
{
    public class SpawnerRandomizer : MonoBehaviour
    {
        [SerializeField] private PooledObjectsSpawner[] spawners;

        [SerializeField] private float initialSpawnTime;
        [SerializeField] private float maximumSpawnTime;

        [Range(0.0f, 2.0f)]
        [SerializeField] private float spawnTimeRandomDeviationPercentage;
        [SerializeField] private float spawnTimeProgressionPercentage;

        [SerializeField] private float waitTime;
        private float _randomizedWaitTime;


        public void Start()
        {
            waitTime = initialSpawnTime;
            _randomizedWaitTime = initialSpawnTime;

            StartCoroutine(InvokeSpawners());
        }

        private void Update()
        {
            float randomValue =
                1 + Random.Range(-spawnTimeRandomDeviationPercentage, spawnTimeRandomDeviationPercentage);

            waitTime -= waitTime * (spawnTimeProgressionPercentage * Time.deltaTime);
            waitTime = Mathf.Clamp(waitTime, maximumSpawnTime, maximumSpawnTime + initialSpawnTime);

            _randomizedWaitTime = waitTime * randomValue;
        }

        private IEnumerator InvokeSpawners()
        {
            while (true)
            {
                if (this.enabled && spawners.Length > 0)
                {
                    int spawnerIndex = Random.Range(0, spawners.Length);

                    PooledObjectsSpawner spawner = spawners[spawnerIndex];

                    if (spawner != null)
                        spawner.SpawnNextObject();
                }

                yield return new WaitForSeconds(_randomizedWaitTime);
            }
        }
    }
}