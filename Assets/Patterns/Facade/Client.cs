using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Facade
{
    public class Client : MonoBehaviour
    {
        private Player player;
        // Start is called before the first frame update
        void Start()
        {
            player = new Player();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                SaveManager.Instance.SaveGame(player);
            }
        }

        private void OnGUI()
        {
            GUI.Label(new Rect(10, 10, 200, 20), "Press S to save player data");
        }
    }
}
