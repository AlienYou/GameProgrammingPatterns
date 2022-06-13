using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Visitor
{
    public class RobotPartActivateVisitor : IRobotPartVisitor
    {
        public void Visit(Robot robot)
        {
            Debug.Log($"Robot walking up.");
        }

        public void Visit(Battery battery)
        {
            Debug.Log($"Battery is charged up.");
        }

        public void Visit(MechanicalArm mechanicalArm)
        {
            Debug.Log($"The thermal imager is turned on.");
        }

        public void Visit(ThermalImager thermalImage)
        {
            Debug.Log($"The thermal imager is turned on.");
        }
    }
}
