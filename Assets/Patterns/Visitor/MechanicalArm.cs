using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Visitor
{
    public class MechanicalArm : IRobotPart
    {
        public void Accept(IRobotPartVisitor robotPartVisitor)
        {
            robotPartVisitor.Visit(this);
        }
    }
}
