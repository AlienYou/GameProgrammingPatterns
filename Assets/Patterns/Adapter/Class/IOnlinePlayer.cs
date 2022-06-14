using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Adapter.Class
{
    public interface IOnlinePlayer
    {
        string GetFirstName(int userId);
        string GetLastName(int userId);
        string GetFullNameLastFirst(int userId);
        string GetFullNameFirstLast(int userId);
    }
}
