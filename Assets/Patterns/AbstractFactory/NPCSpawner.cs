using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.AbstractFactory
{
    public class NPCSpawner : MonoBehaviour
    {
        IAnimal cat;
        IAnimal dog;

        IHuman beggar;
        IHuman farmer;
        IHuman shopowner;

        public void SpawnAnimal()
        {
            var factory = FactoryProducer.GetFactory(FactoryType.Animal);
            cat = factory.GetAnimal(AnimalType.Cat);
            dog = factory.GetAnimal(AnimalType.Dog);
            cat.Voice();
            dog.Voice();
        }

        public void SpawnHuman()
        {
            var factory = FactoryProducer.GetFactory(FactoryType.Human);
            beggar = factory.GetHuman(HumanType.Beggar);
            farmer = factory.GetHuman(HumanType.Farmer);
            shopowner = factory.GetHuman(HumanType.Shopowner);
            beggar.Speak();
            farmer.Speak();
            shopowner.Speak();
        }
    }
}

