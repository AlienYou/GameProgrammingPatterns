using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Decorator
{
    public class Client : MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.B))
            {
                IRifle rifle = new BasicRifle();
                Debug.Log($"Basic accuracy: {rifle.GetAccuracy()}");
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                IRifle rifle = new BasicRifle();
                rifle = new WithScope(rifle);
                Debug.Log($"WithScope accurancy: {rifle.GetAccuracy()}");
            }
            else if (Input.GetKeyDown(KeyCode.T))
            {
                IRifle rifle = new BasicRifle();
                rifle = new WithScope(new WithStabilizer(rifle));
                Debug.Log($"Stabilizer+Scope accuracy: {rifle.GetAccuracy()}");
            }
        }

        private void OnGUI()
        {
            GUI.Label(new Rect(10, 10, 200, 20), "Press B to get basic rifle accuracy");
            GUI.Label(new Rect(10, 30, 200, 20), "Press S to get basic rifle with scope");
            GUI.Label(new Rect(10, 60, 200, 20), "Press T to get basic rifle with stabilizer");
        }
    }
}

