using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Utilities
{
    public class GenericMonoSigleton<T> : MonoBehaviour where T : GenericMonoSigleton<T>
    {
        public static T Instance { get { return instance; } }
        private static T instance;

        private void Awake()
        {
            if (instance == null)
            {
                instance = (T) this;
            }
            else
            {
                Destroy(this.gameObject);
            }
        }
    }
}