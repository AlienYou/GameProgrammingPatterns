using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.SpatialPartition
{
    public interface IUnit 
    {
        void AddToGrid(int square);
        int GetGridPosition();
    }
}

