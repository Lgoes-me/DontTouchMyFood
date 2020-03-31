using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(fileName = "ModuleController", menuName = "Managers/Modules", order = 1)]
public class SO_MultiLevelController : ScriptableObject
{
    public string[] levels;
    public int currentLevel = 0;
        
    public void Init()
    {
        currentLevel = 0;
        SceneManager.LoadSceneAsync(levels[currentLevel], LoadSceneMode.Additive);
    }

    public void NextLevel()
    {
        if (currentLevel < levels.Length - 1)
        {
            currentLevel += 1;
            SceneManager.UnloadSceneAsync(levels[currentLevel - 1]);
            SceneManager.LoadSceneAsync(levels[currentLevel], LoadSceneMode.Additive);
        }
    }
}
