using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Strategy
{
    public class SeekWithSonar : ISeekBehaviour 
    {
        public void Seek()
        {
            Debug.Log($"Seeking with sonar");
        }
    }
}
