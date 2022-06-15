using System.IO;
using UnityEngine;
public class DataManager : MonoBehaviour
{
    public static DataManager Instance;
    public string namee = "NULL";
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);

    }
    [System.Serializable]
    class SaveData
    {
        public int highScore;
    }
    public void SaveHighScore()
    {
        SaveData data = new SaveData();
        data.highScore = MainManager.mm.m_Points;

        string json = JsonUtility.ToJson(data);
    
        File.WriteAllText(Application.persistentDataPath + "/highScore.json", json);
    }
    public void LoadHighScore()
    {
        string path = Application.persistentDataPath + "/highScore.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            MainManager.mm.highScore = data.highScore;
        }
    }
// --------------------------------------------------------
    
}
