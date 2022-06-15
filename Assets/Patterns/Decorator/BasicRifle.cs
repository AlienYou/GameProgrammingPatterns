using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Decorator
{
    public class BasicRifle : IRifle
    {
        private float basicAccurancy = 5.0f;
        public float GetAccuracy()
        {
            return basicAccurancy;
        }
    }

}
