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
    public BoolVariable triggerTransition;
    
    void Awake()
    {
        SceneManager.LoadSceneAsync(levels[currentLevel], LoadSceneMode.Additive);
    }

    public void EndLevel(bool didWin)
    {
        if (didWin) NextLevel();
    }

    private void NextLevel()
    {
        if (currentLevel < levels.Length - 1)
        {
            currentLevel += 1;
            StartCoroutine(LoadNextLevel(currentLevel));
        }
    }

    private IEnumerator LoadNextLevel(int levelIndex)
    {
        AsyncOperation asyncLoadOperation = SceneManager.LoadSceneAsync(levels[levelIndex], LoadSceneMode.Additive);
        triggerTransition.Value = false;
        yield return new WaitUntil(() => asyncLoadOperation.isDone);

        AsyncOperation asyncUnloadOperation = SceneManager.UnloadSceneAsync(levels[levelIndex - 1]);
        yield return new WaitUntil(() => asyncUnloadOperation.isDone);

        levelStarted.Raise();
    }
}
