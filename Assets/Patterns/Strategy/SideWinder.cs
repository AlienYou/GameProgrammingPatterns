using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Strategy
{
    public class SideWinder : Missile
    {
        void Awake()
        {
            this.seekBehaviour = new SeekWithHeat();
        }
    }
}
