using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Factory
{
    public class NPCFatory : MonoBehaviour
    {
        public INPC GetNPC(NPCType type)
        {
            switch (type)
            {
                case NPCType.Farmer:
                    return new Farmer();
                case NPCType.Beggar:
                    return new Beggar();
                case NPCType.Shopowner:
                    return new Shopowner();
                default:
                    break;
            }
            return null;
        }
    }
}
