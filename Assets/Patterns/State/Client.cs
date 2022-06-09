using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.State
{
    public class Client : MonoBehaviour
    {
        public Ship ship;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.N))
            {
                ship.Normalize();
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                ship.TriggerRedAlert();
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                ship.DisbaleShip();
            }
        }

        private void OnGUI()
        {
            GUI.Label(new Rect(10, 10, 200, 20), "Press N to normalize");
            GUI.Label(new Rect(10, 30, 200, 20), "Press A to alert");
            GUI.Label(new Rect(10, 60, 200, 20), "Press D to disable");
        }
    }
}
