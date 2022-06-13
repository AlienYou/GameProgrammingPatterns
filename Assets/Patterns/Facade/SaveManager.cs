using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Patterns.Singleton;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Patterns.Facade
{
    public class SaveManager : Singleton<SaveManager>
    {
        private UIManager uiManager;
        private PlayerData playerData;
        private ScoreManager scoreManager;
        private CloudManager cloudManager;

        public void SaveGame(Player player)
        {
            uiManager = new UIManager();
            uiManager.DisplaySaveIcon();

            playerData = new PlayerData();
            playerData.health = player.GetHealth();
            playerData.playerID = player.GetPlayerID();

            scoreManager = new ScoreManager();
            playerData.score = scoreManager.GetScore(player.GetPlayerID());

            SerializePlayerData(playerData, true);
        }

        private void SerializePlayerData(PlayerData playerData, bool isCloudSave)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Create(Application.persistentDataPath + "/playerInfo.dat");
            bf.Serialize(file, playerData);
            file.Close();

            if (isCloudSave)
            {
                cloudManager = new CloudManager();
                cloudManager.UploadSaveGame(Application.persistentDataPath + "/playerInfo.dat");
            }
        }
    }
}
