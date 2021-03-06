using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Prototype
{
    public class EnemySpawner : MonoBehaviour
    {
        public ICopyable iCopy;

        public Enemy SpawnEnemy(Enemy prototype)
        {
            return (Enemy)prototype.Copy();
        }
    }
}
