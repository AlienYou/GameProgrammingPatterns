using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Adapter.Class
{
    public class Client : MonoBehaviour
    {
        private OnlinePlayerClassAdapter onlinePlayer;
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.U))
            {
                onlinePlayer = ScriptableObject.CreateInstance<OnlinePlayerClassAdapter>();

                string firstName = onlinePlayer.GetFirstName(79);
                string lastName = onlinePlayer.GetLastName(79);

                string fullNameLastFirst = onlinePlayer.GetFullNameLastFirst(79);
                string fullNameFirstLast = onlinePlayer.GetFullNameFirstLast(79);

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
