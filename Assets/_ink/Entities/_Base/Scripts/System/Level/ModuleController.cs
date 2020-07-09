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
            PreviousLevel();
        }
    }

    public void PreviousLevel()
    {
        if (currentLevel > 0)
        {
            StartCoroutine(UnloadLevel());
            currentLevel -= 1;
            StartCoroutine(LoadLevel());
        }
    }

    private IEnumerator LoadLevel()
    {
        AsyncOperation asyncLoadOperation = SceneManager.LoadSceneAsync(levels[currentLevel], LoadSceneMode.Additive);
        Scene nextScene = SceneManager.GetSceneByName(levels[currentLevel]);
        yield return new WaitUntil(() => asyncLoadOperation.isDone);
        SceneManager.SetActiveScene(nextScene);
        levelStarted.Raise();
    }

    private IEnumerator UnloadLevel()
    {
        AsyncOperation asyncUnloadOperation = SceneManager.UnloadSceneAsync(levels[currentLevel]);
        yield return new WaitUntil(() => asyncUnloadOperation.isDone);
    }

}
