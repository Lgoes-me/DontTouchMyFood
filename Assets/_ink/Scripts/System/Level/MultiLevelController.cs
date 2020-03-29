using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(fileName = "ModuleController", menuName = "Managers/Modules", order = 1)]
public class MultiLevelController : ScriptableObject
{
    public List<Scene> levels;
    public Scene currentLevel;

    public void NextLevel()
    {
        SceneManager.SetActiveScene(currentLevel);
    }

}
