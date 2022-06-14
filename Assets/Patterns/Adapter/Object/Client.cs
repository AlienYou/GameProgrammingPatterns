using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Adapter.Object
{
    public class Client : MonoBehaviour
    {
        private OnlinePlayer onlinePlayer;
        private OnlinePlayerObjectAdapter onLinePlayerAdapter;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.U))
            {
                onlinePlayer = ScriptableObject.CreateInstance<OnlinePlayer>();
                onLinePlayerAdapter = ScriptableObject.CreateInstance<OnlinePlayerObjectAdapter>();

                string firstName = onlinePlayer.GetFirstName(79);
                string lastName = onlinePlayer.GetLastName(79);

                string fullNameLastFirst = onlinePlayer.GetFullName(79);
                string fullNameFirstLast = onLinePlayerAdapter.GetFullName(onlinePlayer, 79);
                Debug.Log(firstName);
                Debug.Log(lastName);
                Debug.Log(fullNameLastFirst);
                Debug.Log(fullNameFirstLast);
            }
        }

        private void OnGUI()
        {
            GUI.Label(new Rect(10, 10, 200, 20), "Press U to print name");
        }
    }
}
