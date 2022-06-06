using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.AbstractFactory
{
    public class Beggar : IHuman
    {
        public void Speak()
        {
            Debug.Log("Do you have some change to spare?");
        }
    }
}
