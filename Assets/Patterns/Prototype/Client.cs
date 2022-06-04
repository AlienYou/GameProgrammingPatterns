using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Patterns.Prototype
{
    public class Client : MonoBehaviour
    {
        public Drone drone;
        public Sniper sniper;
        public EnemySpawner enemySpawner;

        Enemy curSpawn;
        int incrementDrone = 0;
        int incrementSniper = 0;

        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                curSpawn = enemySpawner.SpawnEnemy(drone);
                curSpawn.transform.Translate(Vector3.forward * incrementDrone * 1.5f);
                curSpawn.name = $"drone_clone_{++incrementDrone}";
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                curSpawn = enemySpawner.SpawnEnemy(sniper);
                curSpawn.transform.Translate(Vector3.forward * incrementSniper * 1.5f);
                curSpawn.name = $"sniper_clone_{++incrementSniper}";
            }
        }

        public void OnGUI()
        {
            GUI.color = Color.black;
            GUI.Label(new Rect(10, 10, 200, 20), "Press A to spawn a drone");
            GUI.Label(new Rect(10, 30, 200, 20), "Press D to spawn a sniper");
        }
    }
}
