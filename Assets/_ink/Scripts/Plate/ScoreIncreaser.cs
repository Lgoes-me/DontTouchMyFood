using UnityEngine;
using ScriptableObjectArchitecture;

public class ScoreIncreaser : MonoBehaviour
{
    //public ScoreController scoreController;
    public BoolVariable shouldIncrease;

    public IntVariable intValue;
    public int variation;



    private void FixedUpdate()
    {
        if (shouldIncrease.Value)
        {
            intValue.Value += variation;
            //scoreController.AddScore(variation);
        }
    }
}
