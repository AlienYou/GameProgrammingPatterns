using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.ObjectPool
{
    public class Client : MonoBehaviour
    {
        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.G))
            {
                var walker = ObjectPool.Instance.PullObject("Walker");
                walker.transform.Translate(Vector3.forward * Random.Range(-5.0f, 5.0f));
                walker.transform.Translate(Vector3.right * Random.Range(-5.0f, 5.0f));
            }
            else if (Input.GetKeyDown(KeyCode.P))
            {
                object[] objs = GameObject.FindObjectsOfType(typeof(GameObject));
                foreach (var o in objs)
                {
                    var obj = (GameObject)o;
                    if (obj.gameObject.GetComponent<Walker>() != null)
                    {
                        ObjectPool.Instance.PoolObject(obj);
                    }
                }
            }
        }

        private void OnGUI()
        {
            GUI.Label(new Rect(10, 10, 200, 20), "Press G to pull gameObject");
            GUI.Label(new Rect(10, 30, 200, 20), "Press P to pool gameObject");
        }
    }
}
