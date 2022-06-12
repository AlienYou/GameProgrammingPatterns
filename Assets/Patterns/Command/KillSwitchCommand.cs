using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Command
{
    public class KillSwitchCommand : Command
    {
        private RemoteControlDevice[] devices;
        private static RemoteControlDevice staticReceiver;

        public KillSwitchCommand(RemoteControlDevice[] devices) : base(staticReceiver)
        {
            this.devices = devices;
        }

        public override void Execute()
        {
            foreach (var device in devices)
            {
                device.TurnOff();
            }
        }
    }
}
