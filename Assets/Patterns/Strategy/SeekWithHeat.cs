using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Strategy
{
    public class SeekWithHeat : ISeekBehaviour 
    {
        public void Seek()
        {
            Debug.Log($"Seeking target with heat signature");
        }
    }
}
