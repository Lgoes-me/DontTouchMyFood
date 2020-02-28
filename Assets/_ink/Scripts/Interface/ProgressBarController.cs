using UnityEngine;
using UnityEngine.UI;
using ScriptableObjectArchitecture;

public class ProgressBarController : MonoBehaviour
{
    public FloatVariable fillPercent;
    private Image image;

    private void Start()
    {
        image = GetComponent<Image>();
    }

    private void FixedUpdate()
    {
        image.fillAmount = fillPercent.Value;
    }
}
