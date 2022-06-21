using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.SpatialPartition
{
    public class Client : MonoBehaviour
    {
        private Grid grid;
        private IUnit[] preys;

        private void Start()
        {
            grid = new Grid(4, 16);
            Debug.Log("Grid generated");
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                IUnit prey;
                int numberOfPrey = 5;
                preys = new IUnit[numberOfPrey];
                for (int i = 0; i < numberOfPrey; ++i)
                {
                    prey = new Prey();
                    grid.AddToRandomPosition(prey);
                    preys[i] = prey;

                    Debug.Log($"A prey was spawned @ square: {preys[i].GetGridPosition()}");
                }
            }
            else if (Input.GetKeyDown(KeyCode.H))
            {
                IUnit predator;
                predator = new Predator();
                grid.AddToRandomPosition(predator);
                Debug.Log($"A predator was spawned @ square: {predator.GetGridPosition()}");

                int closest = grid.FindClosest(predator, preys);
                Debug.Log($"The closest prey is @ square: {closest}");
            }
        }

        private void OnGUI()
        {
            GUI.color = Color.black;
            GUI.Label(new Rect(10, 10, 200, 20), "Press P to spawn prey on the grid.");
            GUI.Label(new Rect(10, 30, 200, 20), "Press H to hunt some prey");
            GUI.Label(new Rect(10, 60, 200, 20), "Open Debug Console to view the output.");
        }
    }
}
