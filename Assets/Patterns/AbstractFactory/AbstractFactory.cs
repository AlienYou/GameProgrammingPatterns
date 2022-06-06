using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.AbstractFactory
{
    public abstract class AbstractFactory
    {
        public abstract IHuman GetHuman(HumanType type);
        public abstract IAnimal GetAnimal(AnimalType type);
    }
}
