using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Strategy
{
    public class Client : MonoBehaviour
    {
        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                Missile sideWinder = ScriptableObject.CreateInstance<SideWinder>();
                sideWinder.ApplySeek();

                Missile torpedo = ScriptableObject.CreateInstance<Torpedo>();
                torpedo.ApplySeek();

                Missile sideWinderWithSonar = ScriptableObject.CreateInstance<Tomahawk>();
                ISeekBehaviour sonar = new SeekWithSonar();
                sideWinderWithSonar.SetSeekBehavior(sonar);
                sideWinderWithSonar.ApplySeek();
            }
        }

        private void OnGUI()
        {
            GUI.Label(new Rect(10, 10, 400, 20), "Press D to Load a set of missiles and apply a seeking behavior");
        }
    }
}
