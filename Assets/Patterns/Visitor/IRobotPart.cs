using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Visitor
{
    public interface IRobotPart 
    {
        void Accept(IRobotPartVisitor robotPartVisitor);
    }
}
