using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Adapter.Class
{
    public class OnlinePlayer : ScriptableObject 
    {
        public string GetFirstName(int id)
        {
            return "John";
        }

        public string GetLastName(int id)
        {
            return "Doe";
        }

        public string GetFullName(int id)
        {
            return "Doe John";
        }
    }
}

