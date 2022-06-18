using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.DependencyInjection
{
    public class HumanDriver : IDriver
    {
        private Bike bike;
        public void Control(Bike bike)
        {
            this.bike = bike;
            Debug.Log("A human (player) will control the bike");
        }
    }
}
