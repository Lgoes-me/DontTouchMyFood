using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndMenuController : MonoBehaviour
{
    public GameObject extraLifeButton;
    [Range(0, 100)]
    public int chance;
    private bool _chanceSpent;

    private void OnEnable()
    {
        extraLifeButton.SetActive(chance >= Random.Range(0, 100) && !_chanceSpent);
    }

    public void Spend(bool isSpent)
    {
        _chanceSpent = isSpent;
    }
}
