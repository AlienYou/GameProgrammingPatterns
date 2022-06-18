using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.DependencyInjection
{
    public class NitroEngine : IEngine
    {
        public void StartEngine()
        {
            OpenNitroValve();
            Debug.Log("Engine started");
        }

        void OpenNitroValve()
        {
            Debug.Log("The nitro valve is open");
        }
    }
}

