using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.EventBus
{
    public class Rocket : MonoBehaviour
    {
        private bool isQuitting;
        private bool isLaunched = false;

        private void OnEnable()
        {
            EventBus.StartListening("Launch", Launch);
        }

        private void OnApplicationQuit()
        {
            isQuitting = true;
        }

        private void OnDisable()
        {
            if (!isQuitting)
            {
                EventBus.StopListening("Launch", Launch);
            }
        }

        void Launch()
        {
            if (!isLaunched)
            {
                isLaunched = true;
                Debug.Log("Received a launch Event : Rocket launching");
            }
        }
    }
}
