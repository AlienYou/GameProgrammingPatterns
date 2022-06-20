using Patterns.Singleton;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.ObjectPool
{
    public class ObjectPool : Singleton<ObjectPool> 
    {
        public GameObject[] objects;

        public List<GameObject>[] pooledObjects;

        public int[] amountToBuffer;

        public int defaultBufferAmount = 3;

        protected GameObject containerObject;

        void Start()
        {
            containerObject = new GameObject("ObjectPool");
            pooledObjects = new List<GameObject>[objects.Length];

            int i = 0;
            foreach (var obj in objects)
            {
                pooledObjects[i] = new List<GameObject>();

                int bufferAmount;

                if (i < amountToBuffer.Length)
                {
                    bufferAmount = amountToBuffer[i];
                }
                else
                {
                    bufferAmount = defaultBufferAmount;
                }

                for (int n = 0; n < bufferAmount; ++n)
                {
                    var newObj = Instantiate(obj) as GameObject;
                    newObj.name = obj.name;
                    PoolObject(newObj);
                }
                i++;
            }
        }

        public GameObject PullObject(string objectType)
        {
            bool onlyPooled = false;
            for (int i = 0; i < objects.Length; ++i)
            {
                var prefab = objects[i];
                if (prefab.name == objectType)
                {
                    var count = pooledObjects[i].Count;
                    if (count > 0)
                    {
                        var pooledObject = pooledObjects[i][count - 1];
                        pooledObject.SetActive(true);
                        pooledObject.transform.parent = null;

                        pooledObjects[i].Remove(pooledObject);

                        return pooledObject;
                    }
                    else if (!onlyPooled)
                    {
                        return Instantiate(objects[i]) as GameObject;
                    }
                    break;
                }
            }
            return null;
        }

        public void PoolObject(GameObject obj)
        {
            for (int i = 0; i < objects.Length; ++i)
            {
                if (objects[i].name == obj.name)
                {
                    obj.SetActive(false);
                    obj.transform.parent = containerObject.transform;
                    pooledObjects[i].Add(obj);
                    return;
                }
            }
            Destroy(obj);
        }
    }
}
