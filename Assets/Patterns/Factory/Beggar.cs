using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Factory
{
    public class Beggar : INPC
    {
        public void Speak()
        {
            Debug.Log("Do you have some change to spare?");
        }
    }
}
