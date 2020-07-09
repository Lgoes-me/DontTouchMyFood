using UnityEngine;
using ScriptableObjectArchitecture;
using System.IO;

public class SaveController : MonoBehaviour
{
    public FloatVariable GameScore, RecordScore;

    private void Awake()
    {
        Application.targetFrameRate = 30;
        LoadData();
    }

    public void SaveData()
    {
        if(GameScore.Value > RecordScore.Value)
        {
            RecordScore.Value = GameScore.Value;
            
            File.WriteAllText($"{Application.persistentDataPath}/save.ink", RecordScore.Value.ToString());
        }
        GameScore.Value = 0;
    }

    public void LoadData()
    {
        if (File.Exists($"{Application.persistentDataPath}/save.ink"))
        {
            string value = File.ReadAllText($"{Application.persistentDataPath}/save.ink");
            float.TryParse(value, out float recordValue);
            RecordScore.Value = recordValue;
        }
        else
        {
            RecordScore.Value = 0f;
        }

        GameScore.Value = 0;
    }
}
