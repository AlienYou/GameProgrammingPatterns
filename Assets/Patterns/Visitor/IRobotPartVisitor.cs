using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Visitor
{
    public interface IRobotPartVisitor 
    {
        void Visit(Robot robot);
        void Visit(Battery battery);
        void Visit(MechanicalArm mechanicalArm);
        void Visit(ThermalImager thermalImage);
    }
}
