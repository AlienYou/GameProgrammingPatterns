using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.AbstractFactory
{
    public class Cat : IAnimal
    {
        public void Voice()
        {
            Debug.Log("Cat:Meow");
        }
    }
}
