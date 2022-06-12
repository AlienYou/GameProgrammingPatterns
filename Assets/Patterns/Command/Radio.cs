using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Patterns.Command
{
    public class RadioReceiver : RemoteControlDevice
    {
        public override void TurnOff()
        {
            Debug.Log("Radio is turned off.");
        }

        public override void TurnOn()
        {
            Debug.Log("Radio is turned on.");
        }
    }
}
