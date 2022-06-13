using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Visitor
{
    public class Client : MonoBehaviour
    {
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.O))
            {
                IRobotPart robot = new Robot();
                robot.Accept(new RobotPartActivateVisitor());
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                IRobotPart robot = new Robot();
                robot.Accept(new RobotPartShutdownVisitor());
            }
        }

        private void OnGUI()
        {
            GUI.Label(new Rect(10, 10, 200, 20), "Press O to activate robot visitor");
            GUI.Label(new Rect(10, 30, 200, 20), "Press S to shut down robot visitor");
        }
    }
}
