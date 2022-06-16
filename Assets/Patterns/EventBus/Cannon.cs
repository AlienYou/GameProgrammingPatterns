using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.EventBus
{
    public class Cannon : MonoBehaviour
    {
        private bool isQuitting;

        private void OnEnable()
        {
            EventBus.StartListening("Shoot", Shoot);
        }

        private void OnApplicationQuit()
        {
            isQuitting = true;
            Debug.Log("Cannon Application Quit");
        }

        private void OnDisable()
        {
            if (!isQuitting)
            {
                EventBus.StopListening("Shoot", Shoot);
            }
            Debug.Log($"Cannon Disable");
        }

        void Shoot()
        {
            Debug.Log($"Received a shoot event : shooting cannon!");
        }
    }
}
