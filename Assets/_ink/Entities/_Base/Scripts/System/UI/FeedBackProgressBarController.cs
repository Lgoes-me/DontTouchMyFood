using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ScriptableObjectArchitecture;

public class FeedBackProgressBarController : MonoBehaviour
{
    public FloatVariable fillPercent;
    public Image otherImage;
    private Image image;

    private void Start()
    {
        image = GetComponent<Image>();
    }

    private void FixedUpdate()
    {
        float value = fillPercent.Value;

        image.fillAmount = Mathf.SmoothStep(otherImage.fillAmount, value, image.fillAmount  - otherImage.fillAmount);
    }
}
