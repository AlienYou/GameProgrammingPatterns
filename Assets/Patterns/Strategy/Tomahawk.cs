using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Strategy
{
    public class Tomahawk : Missile 
    {
        void Awake()
        {
            this.seekBehaviour = new SeekWithGPS();
        }
    }

}
