using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.DependencyInjection
{
    public class JetEngine : IEngine 
    {
        public void StartEngine()
        {
            ActivateJetStream();
            Debug.Log("Engine started");
        }

        private void ActivateJetStream()
        {
            Debug.Log("The jet stream is activated");
        }
    }
}
