using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Visitor
{
    public class Robot : IRobotPart 
    {
        private IRobotPart[] robotParts;
        public Robot()
        {
            robotParts = new IRobotPart[] { new MechanicalArm(), new ThermalImager(), new Battery() };
        }
        public void Accept(IRobotPartVisitor robotPartVisitor)
        {
            for (int i = 0, icnt = robotParts.Length; i < icnt; ++i)
            {
                robotParts[i].Accept(robotPartVisitor);
            }
            robotPartVisitor.Visit(this);
        }
    }
}
