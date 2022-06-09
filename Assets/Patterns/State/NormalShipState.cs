using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.State
{
    public class NormalShipState : IShipState 
    {
        public void Execute(Ship ship)
        {
            Debug.Log($"NORMAL: ship operating as normal.");
        }
    }
}
