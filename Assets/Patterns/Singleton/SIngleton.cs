using UnityEngine;

namespace Patterns.Singleton
{
    public class Singleton<T> : MonoBehaviour where T : Component
    {
        static T _instance;

        public static T Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = FindObjectOfType<T>();
                    if (_instance == null)
                    {
                        GameObject go = new GameObject();
                        go.name = typeof(T).Name;
                        _instance = go.AddComponent<T>();
                    }
                }
                return _instance;
            }
        }

        public virtual void Awake()
        {
            if (_instance == null)
            {
                _instance = this as T;
                DontDestroyOnLoad(gameObject);
                Debug.Log($"_instance {gameObject.name} awake");
            }
            else
            {
                Debug.Log($"_instance {gameObject.name} Destroy");
                Destroy(gameObject);
            }
        }
    }
}

