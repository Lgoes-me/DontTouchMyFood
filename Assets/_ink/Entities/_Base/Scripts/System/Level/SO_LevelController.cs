using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(fileName = "LevelController", menuName = "Managers/Level", order = 1)]
public class SO_LevelController : ScriptableObject
{
    public LoadSceneMode loadSceneMode;

    public void ChangeScene( string sceneName)
    {
        SceneManager.LoadScene(sceneName, loadSceneMode);
    }

    public void ChangeScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex, loadSceneMode);
    }
}
