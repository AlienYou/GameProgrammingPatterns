using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Factory
{
    public class Client : MonoBehaviour
    {
        public NPCSpawner spawnerNPC;

        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                spawnerNPC.SpawnVillagers();
            }
        }

        public void OnGUI()
        {
            GUI.Label(new Rect(10, 10, 200, 20), "Please press S to spawn NPCs");
            GUI.Label(new Rect(10, 30, 200, 20), "Look debug speak");
        }
    }
}

