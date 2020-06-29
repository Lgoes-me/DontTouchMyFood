using UnityEngine;

[CreateAssetMenu(fileName = "Color", menuName = "Configuration/Colors", order = 1)]
public class LevelColor : ScriptableObject
{
    public Color[] colors = new Color[5];

    /*
#if UNITY_EDITOR
    public bool isInitialized = false;
    private ColorColtroller _controller;

    public void Init(ColorColtroller controller)
    {
        _controller = controller;
        isInitialized = true;
    }

    private void OnValidate()
    {
        _controller.ChangeColor();
    }
#endif
*/
}
