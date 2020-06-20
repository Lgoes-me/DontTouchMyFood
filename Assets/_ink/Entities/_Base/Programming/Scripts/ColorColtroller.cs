using UnityEngine;
using UnityEngine.UI;


public class ColorColtroller : MonoBehaviour
{
    public LevelColor[] levelPresetColor;
    public GameObject[] gameObjects;

    private void Awake()
    {
        int colorIndex = Random.Range(0, levelPresetColor.Length);

        for(int i = 0; i < gameObjects.Length; i++)
        {
            if (gameObjects[i].TryGetComponent<SpriteRenderer>(out SpriteRenderer spriteRenderer))
            {
                spriteRenderer.color = levelPresetColor[colorIndex].colors[i];

            } else if(gameObjects[i].TryGetComponent<Image>(out Image image))
            {
                image.color = levelPresetColor[colorIndex].colors[i];
            }
        }
    }
}
