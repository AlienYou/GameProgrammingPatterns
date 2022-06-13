using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Facade
{
    public class ScoreManager
    {
        public int GetScore(int playerId)
        {
            Debug.Log("Returning player score.");
            return 0;
        }
    }
}
