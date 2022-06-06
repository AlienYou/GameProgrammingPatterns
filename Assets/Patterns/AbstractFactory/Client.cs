using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.AbstractFactory
{
    public class Client : MonoBehaviour
    {
        public NPCSpawner spawner;
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                spawner.SpawnAnimal();
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                spawner.SpawnHuman();
            }
        }

        private void OnGUI()
        {
            GUI.color = Color.black;
            GUI.Label(new Rect(10, 10, 200, 20), "Press W to spawn animal");
            GUI.Label(new Rect(10, 30, 200, 20), "Press S to spawn human");
        }
    }
}
