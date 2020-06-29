using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class ColorColtroller : MonoBehaviour
{
    public LevelColor[] levelPresetColor;
    public GameObject[] gameObjects;

    public int colorIndex = 0;

    [ContextMenu("ChangeToRandomColor")]
    public void ChangeToRandomColor()
    {
        int newIndex = Random.Range(0, levelPresetColor.Length);

        if(colorIndex == newIndex)
        {
            ChangeToRandomColor();
            return;
        }
        colorIndex = newIndex;

        ChangeColor();
    }

    [ContextMenu("ChangeColor")]
    public void ChangeColor()
    {
        colorIndex = Mathf.Clamp(colorIndex, 0, levelPresetColor.Length);

        for (int i = 0; i < gameObjects.Length; i++)
        {
            if (gameObjects[i].TryGetComponent<SpriteRenderer>(out SpriteRenderer spriteRenderer))
            {
                spriteRenderer.color = levelPresetColor[colorIndex].colors[i];

            }
            else if (gameObjects[i].TryGetComponent<Image>(out Image image))
            {
                image.color = levelPresetColor[colorIndex].colors[i];
            }
        }
    }
    /*
#if UNITY_EDITOR

    public LevelColor currentColor;

    private void OnValidate()
    {
        for (int i = 0; i < levelPresetColor.Length; i++)
        {
            levelPresetColor[i].Init(this);
        }

        currentColor = levelPresetColor[colorIndex];
        ChangeColor();
    }
#endif
*/
}
