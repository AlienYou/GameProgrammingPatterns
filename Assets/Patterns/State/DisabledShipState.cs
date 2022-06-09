using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.State
{
    public class DisabledShipState : IShipState
    {
        public void Execute(Ship ship)
        {
            Debug.Log($"DISABLED: crew jumping ship.");
        }
    }
}
