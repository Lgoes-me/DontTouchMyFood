using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(fileName = "ModuleController", menuName = "Managers/Modules", order = 1)]
public class SO_MultiLevelController : ScriptableObject
{
    public string [] levelNames;
    public int currentLevel = 0;
    
    public void Init()
    {
        currentLevel = 0;
        SceneManager.LoadSceneAsync(levelNames[currentLevel], LoadSceneMode.Additive);
    }

    public void NextLevel()
    {
        if(currentLevel < levelNames.Length - 1)
        {
            SceneManager.UnloadSceneAsync(levelNames[currentLevel]);
            currentLevel += 1;
            SceneManager.LoadSceneAsync(levelNames[currentLevel], LoadSceneMode.Additive);
        }
    }
}
