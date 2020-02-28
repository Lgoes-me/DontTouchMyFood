using UnityEngine;
using ScriptableObjectArchitecture;

public class IntIncreaser : MonoBehaviour
{
    public BoolVariable shouldIncrease;

    public IntVariable intValue;
    public int variation;

    private void FixedUpdate()
    {
        if(shouldIncrease.Value) intValue.Value += variation;
    }
}
