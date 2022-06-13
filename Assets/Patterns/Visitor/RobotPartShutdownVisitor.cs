using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Visitor
{
    public class RobotPartShutdownVisitor : IRobotPartVisitor 
    {
        public void Visit(Robot robot)
        {
            Debug.Log("Robot is going back to sleep.");
        }

        public void Visit(Battery battery)
        {
            Debug.Log($"Battery is charging down.");
        }

        public void Visit(MechanicalArm mechanicalArm)
        {
            Debug.Log($"The mechanical arm is folding back to it's default position");
        }

        public void Visit(ThermalImager thermalImage)
        {
            Debug.Log($"The thermal imager is turned off.");
        }
    }
}
