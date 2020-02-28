using UnityEngine;
using UnityEngine.UI;
using ScriptableObjectArchitecture;

public class ProgressBarController : MonoBehaviour
{
    //public IntVariable maxScore, currentScore;
    public FloatVariable fillPercent;

    private Image image;

    private void Start()
    {
        image = GetComponent<Image>();
    }

    private void FixedUpdate()
    {
        //image.fillAmount = (float)currentScore.Value / maxScore.Value;
        image.fillAmount = fillPercent.Value;
    }
}
