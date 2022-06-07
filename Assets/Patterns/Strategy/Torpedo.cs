using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Strategy
{
    public class Torpedo : Missile
    {
        void Awake()
        {
            this.seekBehaviour = new SeekWithSonar();
        }
    }
}
