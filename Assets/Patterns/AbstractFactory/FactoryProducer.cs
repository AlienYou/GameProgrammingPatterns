using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.AbstractFactory
{
    public class FactoryProducer : MonoBehaviour
    {
        public static AbstractFactory GetFactory(FactoryType type)
        {
            switch (type)
            {
                case FactoryType.Human:
                    return new HumanFactory();
                case FactoryType.Animal:
                    return new AnimalFactory();
                default:
                    break;
            }
            return null;
        }
    }
}
