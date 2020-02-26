using UnityEngine;
using TMPro;
using ScriptableObjectArchitecture;

public class TimerController : MonoBehaviour
{
    public FloatVariable timer;
    public BoolVariable isTimerRunning;

    private TextMeshProUGUI textMesh;

    private void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
    }

    void FixedUpdate()
    {
        if(isTimerRunning.Value && timer.Value > 0)
        {
            timer.Value -= Time.deltaTime;
            textMesh.text = timer.Value.ToString("0.00");
        }
    }
}
