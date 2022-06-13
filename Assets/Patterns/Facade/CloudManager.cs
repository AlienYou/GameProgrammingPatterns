using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Facade
{
    public class CloudManager 
    {
        public void UploadSaveGame(string playerData)
        {
            Debug.Log($"Uploading save data.");
        }
    }
}
