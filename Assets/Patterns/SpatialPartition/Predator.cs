using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.SpatialPartition
{
    public class Predator : IUnit
    {
        private int square;
        public void AddToGrid(int square)
        {
            this.square = square;
        }

        public int GetGridPosition()
        {
            return square;
        }
    }
}
