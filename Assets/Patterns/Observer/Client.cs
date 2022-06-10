using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Observer
{
    public class Client : MonoBehaviour
    {
        private void OnGUI()
        {
            GUI.Label(new Rect(10, 10, 300, 20), "Look at the console window to watch the countdown and the events getting triggered.");
        }
    }
}
