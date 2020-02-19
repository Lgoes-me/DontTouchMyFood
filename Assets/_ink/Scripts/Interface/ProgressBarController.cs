using UnityEngine;
using UnityEngine.UI;

public class ProgressBarController : MonoBehaviour
{
    public float eatenPercentage;
    private Image image;

    private void Start()
    {
        image = GetComponent<Image>();
    }

    private void FixedUpdate()
    {
        image.fillAmount = eatenPercentage / 100f;
    }
}
