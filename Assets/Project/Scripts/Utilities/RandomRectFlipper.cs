using UnityEngine;

namespace Project.Scripts.Utilities
{
    public class RandomRectFlipper : MonoBehaviour
    {
        [SerializeField] private RectTransform rectTransform;


        private void Start()
        {
            Vector3 scale = rectTransform.localScale;
            float x = scale.x;
            bool doFlip = RandomUtilities.Bool;

            if (doFlip)
                x *= -1;

            scale.x = x;

            rectTransform.localScale = scale;
            
            Destroy(this);
        }
    }
}