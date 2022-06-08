using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Singleton
{
    public class GameManager : Singleton<GameManager>
    {
        public void InitializeGame()
        {
            Debug.Log("Initializing the game.");
        }
    }
}
