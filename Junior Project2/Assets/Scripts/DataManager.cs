using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class DataManager : MonoBehaviour
{
    public static DataManager instance;

    public TMP_InputField namePlayerInput;

    public string playerName;
    private int currentPoint;

    string hightPlayerName;
    int hightPlayerPoint;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void StartGame()
    {
        playerName = namePlayerInput.text;
        SceneManager.LoadScene(1);
    }

    public void Set_Point(int point)
    {
        currentPoint = point;
    }

    public int Get_Point()
    {
        return currentPoint;
    }

    [System.Serializable]
    class SaveData
    {
        public string name;
        public int point;
    }

    public void saveHightScore()
    {
        SaveData data = new SaveData();
        data.name = "Demo Name";
        data.point = 10;

        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath+"/savefile.json",json);
    }

    public void loadHightScore()
    {
        string path = Application.persistentDataPath + "savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            hightPlayerName = data.name;
            hightPlayerPoint = data.point;

        }
    }

    public bool checkHightScore(int currentPoint,int hightPoint)
    {
        if (currentPoint > hightPoint)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
