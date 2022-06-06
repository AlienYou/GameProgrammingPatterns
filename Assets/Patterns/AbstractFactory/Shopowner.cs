using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.AbstractFactory
{
    public class Shopowner : IHuman 
    {
        public void Speak()
        {
            Debug.Log("Do you with to purchase something?");
        }
    }
}
