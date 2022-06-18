using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.DependencyInjection
{
    public class AndroidDriver : IDriver
    {
        private Bike bike;
        public void Control(Bike bike)
        {
            this.bike = bike;
            Debug.Log("This bike will be controlled by an AI");
        }
    }
}
