using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.AbstractFactory
{
    public class HumanFactory : AbstractFactory
    {
        public override IAnimal GetAnimal(AnimalType type)
        {
            return null;
        }

        public override IHuman GetHuman(HumanType type)
        {
            switch (type)
            {
                case HumanType.Farmer:
                    return new Farmer();
                case HumanType.Beggar:
                    return new Beggar();
                case HumanType.Shopowner:
                    return new Shopowner();
                default:
                    break;
            }
            return null;
        }
    }
}
