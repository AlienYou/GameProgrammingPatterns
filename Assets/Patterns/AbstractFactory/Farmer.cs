using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.AbstractFactory
{
    public class Farmer : IHuman 
    {
        public void Speak()
        {
            Debug.Log("You reap what you sow");
        }
    }
}
