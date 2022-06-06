using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.AbstractFactory
{
    public class AnimalFactory : AbstractFactory
    {
        public override IAnimal GetAnimal(AnimalType type)
        {
            switch (type)
            {
                case AnimalType.Dog:
                    return new Dog();
                case AnimalType.Cat:
                    return new Cat();
                default:
                    break;
            }
            return null;
        }

        public override IHuman GetHuman(HumanType type)
        {
            return null;
        }
    }
}
