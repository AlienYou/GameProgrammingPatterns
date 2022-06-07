using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Strategy
{
    public abstract class Missile : ScriptableObject
    {
        protected ISeekBehaviour seekBehaviour;

        public void ApplySeek()
        {
            seekBehaviour.Seek();
        }

        public void SetSeekBehavior(ISeekBehaviour seekType)
        {
            this.seekBehaviour = seekType;
        }
    }
}
