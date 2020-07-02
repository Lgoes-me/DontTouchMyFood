using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using ScriptableObjectArchitecture;

public class ModuleController : MonoBehaviour
{
    public SO_LevelConfiguration config;
    public GameEvent levelStarted;

    private int currentLevel = 0;
    private string[] levels;
        
    void Awake()
    {
        levels = config.levels;

        StartCoroutine(LoadLevel());
    }
   
    public void NextLevel()
    {
        if (currentLevel < levels.Length - 1)
        {
            StartCoroutine(UnloadLevel());
            currentLevel += 1;
            StartCoroutine(LoadLevel());
        }
        else
        {
            levelStarted.Raise();
        }
    }

    private IEnumerator LoadLevel()
    {
        AsyncOperation asyncLoadOperation = SceneManager.LoadSceneAsync(levels[currentLevel], LoadSceneMode.Additive);
        yield return new WaitUntil(() => asyncLoadOperation.isDone);
        levelStarted.Raise();
    }

    private IEnumerator UnloadLevel()
    {
        AsyncOperation asyncUnloadOperation = SceneManager.UnloadSceneAsync(levels[currentLevel]);
        yield return new WaitUntil(() => asyncUnloadOperation.isDone);
    }

}
