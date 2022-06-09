using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.State
{
    public interface IShipState
    {
        void Execute(Ship ship);
    }
}
