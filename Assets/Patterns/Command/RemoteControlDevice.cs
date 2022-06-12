using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Command
{
    public abstract class RemoteControlDevice 
    {
        public abstract void TurnOn();
        public abstract void TurnOff();
    }
}
