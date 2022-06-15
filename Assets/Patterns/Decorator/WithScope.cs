using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Decorator
{
    public class WithScope : RifleDecorator
    {
        private float scopeAccurancy = 20.0f;
        public WithScope(IRifle rifle) : base(rifle) { }
        public override float GetAccuracy()
        {
            return base.GetAccuracy() + scopeAccurancy;
        }
    }
}
