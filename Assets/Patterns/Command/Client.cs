using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Patterns.Command
{
    class Client : MonoBehaviour
    {
        private RemoteControlDevice radioReceiver;
        private RemoteControlDevice televisionReceiver;
        private RemoteControlDevice[] devices = new RemoteControlDevice[2];
        private void Start()
        {
            radioReceiver = new RadioReceiver();
            televisionReceiver = new TelevisionReceiver();

            devices[0] = radioReceiver;
            devices[1] = televisionReceiver;
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.O))
            {
                Command commandTV = new TurnOnCommand(devices[0]);
                Command commandRadio = new TurnOffCommand(devices[1]);

                Invoker invoker = new Invoker();
                invoker.SetCommand(commandTV);
                invoker.ExecuteCommand();

                invoker.SetCommand(commandRadio);
                invoker.ExecuteCommand();
            }
            else if (Input.GetKeyDown(KeyCode.K))
            {
                Command commandKill = new KillSwitchCommand(devices);
                Invoker invoker = new Invoker();
                invoker.SetCommand(commandKill);
                invoker.ExecuteCommand();
            }
        }
    }
}
