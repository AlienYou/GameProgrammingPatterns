using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Visitor
{
    public class Battery : IRobotPart
    {
        public void Accept(IRobotPartVisitor robotPartVisitor)
        {
            robotPartVisitor.Visit(this);
        }
    }
}
