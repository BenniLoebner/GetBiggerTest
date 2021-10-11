using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem 
{
    public static void SavePlayer()
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.stats";
        FileStream stream = new FileStream(path, FileMode.Create);

        UpgradeManager stats = new UpgradeManager();

        formatter.Serialize(stream, stats);
        stream.Close();
    }

    public static UpgradeManager LoadStats()
    {
      string path = Application.persistentDataPath + "/player.stats";
      if(File.Exists(path))
      {
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream stream = new FileStream(path, FileMode.Open);

        UpgradeManager stats = formatter.Deserialize(stream) as UpgradeManager;
        stream.Close(); 

        return stats;
      } 
      else
      {
        Debug.LogError("Save file not found in" + path);
        return null;  
      }
    }
}
