using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectRandomChild : MonoBehaviour
{
    public GameObject[] childs;

    private void OnEnable()
    {
        SelectRandom();
    }

    public void SelectRandom()
    {
        int choosenChild = Random.Range(0, childs.Length);

        for (int i = 0; i < childs.Length; i++)
        {
            childs[i].SetActive(i == choosenChild);
        }
    }
}
