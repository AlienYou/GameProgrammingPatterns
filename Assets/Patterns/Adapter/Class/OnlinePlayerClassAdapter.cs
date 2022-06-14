using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Adapter.Class
{
    public class OnlinePlayerClassAdapter : OnlinePlayer, IOnlinePlayer
    {
        public string GetFullNameFirstLast(int userId)
        {
            return GetFullName(userId);
        }

        public string GetFullNameLastFirst(int userId)
        {
            return GetFirstName(userId) + " " + GetLastName(userId);
        }
    }
}
