using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace AS 
{
    public sealed class SaveData
    {
        public static void SavePlayer(PlayerStats playerStats)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            string path = Application.persistentDataPath + "/player.save";
            FileStream fileStream = new FileStream(path, FileMode.Create);

            PlayerData playerData = new PlayerData(playerStats);

            formatter.Serialize(fileStream, playerData);
            fileStream.Close();
        }

        public static PlayerData LoadPlayer()
        {
            string path = Application.persistentDataPath + "/player.save";
            if (File.Exists(path))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                FileStream fileStream = new FileStream(path, FileMode.Open);

                PlayerData playerData = binaryFormatter.Deserialize(fileStream) as PlayerData;
                fileStream.Close();

                return playerData;
            }
            else
            {
                Debug.LogError("Файл сохранения отсутствует");
                return null;
            }
        }
    } 
}
