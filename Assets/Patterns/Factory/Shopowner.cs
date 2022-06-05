using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Factory
{
    public class Shopowner : INPC
    {
        public void Speak()
        {
            Debug.Log("Do you with to purchase something?");
        }
    }
}
