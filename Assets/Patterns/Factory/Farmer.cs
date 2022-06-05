using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Factory
{
    public class Farmer : INPC
    {
        public void Speak()
        {
            Debug.Log("You reap what you sow");
        }
    }
}
