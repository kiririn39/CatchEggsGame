using System;
using Random = UnityEngine.Random;

namespace Project.Scripts.Utilities
{
    public static class RandomUtilities
    {
        public static bool Bool
        {
            get
            {
                int randomValue = Random.Range(0, 2);
                return Convert.ToBoolean(randomValue);
            }
        }
    }
}