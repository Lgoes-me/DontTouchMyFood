using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ScriptableObjectArchitecture;

public class LerpedProgressBarController : MonoBehaviour
{
    public FloatVariable fillPercent;
    public bool invertido;
    public float minValue, maxValue;
    private Image image;

    private void Start()
    {
        image = GetComponent<Image>();
    }

    private void FixedUpdate()
    {
        float value = fillPercent.Value;

        if (image.fillAmount != value) image.fillAmount = invertido ? LerpValue( 1 - value) : LerpValue( value);
    }

    private float LerpValue( float value)
    {
        return Mathf.Lerp(minValue, maxValue, value);
    }
}
