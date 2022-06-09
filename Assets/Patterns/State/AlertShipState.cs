using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.State
{
    public class AlertShipState : IShipState 
    {
        public void Execute(Ship ship)
        {
            Debug.Log($"ALERT: all hands on deck.");
        }
    }
}
