using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.EventBus
{
    public class EventPublisher : MonoBehaviour
    {
        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                EventBus.TriggerEvent("Shoot");
            }
            else if (Input.GetKeyDown(KeyCode.L))
            {
                EventBus.TriggerEvent("Launch");
            }
        }

        private void OnGUI()
        {
            GUI.Label(new Rect(10, 10, 200, 20), "Press S to trigger shoot");
            GUI.Label(new Rect(10, 30, 200, 20), "Press L to trigger launch");
        }
    }
}
