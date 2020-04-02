using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using ScriptableObjectArchitecture;

public class ModuleController : MonoBehaviour
{
    public string[] levels;
    public int currentLevel = 0;
    
    public GameEvent levelStarted;
    
    void Awake()
    {
        StartCoroutine(LoadLevel());
    }

    public void EndLevel(bool didWin)
    {
        if (didWin)
        {
            NextLevel();
        }
    }

    private void NextLevel()
    {
        if (currentLevel < levels.Length - 1)
        {
            StartCoroutine(UnloadLevel());
            currentLevel += 1;
            StartCoroutine(LoadLevel());
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
