using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Command
{
    public abstract class Command
    {
        protected RemoteControlDevice receiver;

        public Command(RemoteControlDevice receiver)
        {
            this.receiver = receiver;
        }

        public abstract void Execute();
    }
}
