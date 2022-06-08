using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Singleton
{
    public class Client : MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.I))
            {
                GameManager.Instance.InitializeGame();
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                InventoryManager.Instance.AddItem(1);
            }
            else if (Input.GetKeyDown(KeyCode.R))
            {
                InventoryManager.Instance.RemoveItem(1);
            }
        }

        public void OnGUI()
        {
            GUI.color = Color.black;
            GUI.Label(new Rect(10, 10, 200, 20), "Press I to initialize game");
            GUI.Label(new Rect(10, 30, 200, 20), "Press A to add item");
            GUI.Label(new Rect(10, 60, 200, 20), "Press R to remove item");
        }
    }
}
