using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceManager : MonoBehaviour
{
    public ButtonInputController button;
    public ProgressBarController progress;
    public float levelPontuation;

    public void Update()
    {
        progress.eatenPercentage = button.pontuation / levelPontuation;
    }
}

