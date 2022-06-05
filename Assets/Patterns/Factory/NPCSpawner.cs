using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Factory
{
    public class NPCSpawner : MonoBehaviour
    {
        public NPCFatory npcFactory;

        private INPC farmer;
        private INPC beggar;
        private INPC shopowner;

        public void SpawnVillagers()
        {
            beggar = npcFactory.GetNPC(NPCType.Beggar);
            farmer = npcFactory.GetNPC(NPCType.Farmer);
            shopowner = npcFactory.GetNPC(NPCType.Shopowner);

            beggar.Speak();
            farmer.Speak();
            shopowner.Speak();
        }
    }
}
