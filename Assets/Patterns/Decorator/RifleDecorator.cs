using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Decorator
{
    public class RifleDecorator : IRifle
    {
        protected IRifle decoratedRifle;
        public RifleDecorator(IRifle rifle)
        {
            decoratedRifle = rifle;
        }
        public virtual float GetAccuracy()
        {
            return decoratedRifle.GetAccuracy();
        }
    }
}
