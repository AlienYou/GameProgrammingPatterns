using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Command
{
    public class TurnOnCommand : Command
    {
        public TurnOnCommand(RemoteControlDevice receiver) : base(receiver)
        {
        }
        public override void Execute()
        {
            receiver.TurnOn();
        }
    }
}
