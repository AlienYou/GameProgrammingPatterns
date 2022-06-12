using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Patterns.Command
{
    public class TelevisionReceiver : RemoteControlDevice
    {
        public override void TurnOff()
        {
            Debug.Log("TV turned off.");
        }

        public override void TurnOn()
        {
            Debug.Log("TV turned on.");
        }
    }
}
