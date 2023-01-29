using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace lgames
{
    public class Singleton : MonoBehaviour
    {

        private static Singleton _instance;

        public static Singleton GetInstance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = FindObjectOfType<Singleton>();
                    if (_instance == null)
                    {
                        _instance = new GameObject().AddComponent<Singleton>();
                    }
                }

                return _instance;
            }
        }

        private void Awake()
        {
            if (_instance != null)
            {
                Log.Warn(this, "Deleting instance, already exist");
                Destroy(this);
            }

            DontDestroyOnLoad(this);
        }

    }
}
