using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.AbstractFactory
{
    public class Dog : IAnimal
    {
        public void Voice()
        {
            Debug.Log("Dog:Woof!");
        }
    }
}
