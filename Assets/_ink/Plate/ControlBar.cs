using ScriptableObjectArchitecture;
using UnityEngine;
using UnityEngine.UI;

public class ControlBar : MonoBehaviour
{
    public FloatVariable eatenPercentage;
    private Image image;

    private void Start()
    {
        image = GetComponent<Image>();    
    }

    private void FixedUpdate()
    {
        image.fillAmount = eatenPercentage.Value/100f;
    }
}
