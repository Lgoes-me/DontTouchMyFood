using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeInController : MonoBehaviour
{
    private CanvasGroup _canvas;
    private float timer;

    private void Awake()
    {
        _canvas = GetComponent<CanvasGroup>();
    }

    private void OnEnable()
    {
        _canvas.alpha = 0;
        timer = 0;
    }

    private void Update()
    {
        if(_canvas.alpha < 1)
        {
            timer += 2 * Time.deltaTime;
            _canvas.alpha = Mathf.Lerp(0, 1, timer);
        }
    }
}
