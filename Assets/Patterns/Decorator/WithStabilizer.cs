using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Decorator
{
    public class WithStabilizer : RifleDecorator
    {
        private float stabilizerAccurancy = 10.0f;
        public WithStabilizer(IRifle rifle) : base(rifle) { }

        public override float GetAccuracy()
        {
            return base.GetAccuracy() + stabilizerAccurancy;
        }
    }
}

