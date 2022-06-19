using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.ServiceLocator
{
    public class Client : MonoBehaviour
    {
        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.O))
            {
                ServiceLocator.Instance.GetService<LightingCoordinator>().TurnOffLights();
            }
            else if (Input.GetKeyDown(KeyCode.C))
            {
                ServiceLocator.Instance.GetService<CurrencyConverter>().ConvertToUsDollar();
            }
            else if (Input.GetKeyDown(KeyCode.L))
            {
                ServiceLocator.Instance.GetService<LobbyCoordinator>().AddPlayerToLobby();
            }
        }

        private void OnGUI()
        {
            GUI.Label(new Rect(10, 10, 200, 20), "Press O to get lighting coordinate");
            GUI.Label(new Rect(10, 30, 200, 20), "Press C to get currency convertor");
            GUI.Label(new Rect(10, 50, 200, 20), "Press L to get lobby Coordinate");
        }
    }
}
