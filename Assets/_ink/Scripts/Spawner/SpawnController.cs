using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScriptableObjectArchitecture;

public class SpawnController : MonoBehaviour
{
    public GameObject prefab;
    public GameObject plate;
    public float waitTime;

    private Camera _camera;

    private void Awake()
    {
        StartCoroutine(Spawn());
        _camera = Camera.main;
    }

    private IEnumerator Spawn()
    {
        yield return new WaitForSeconds(waitTime);
        GameObject paw = Instantiate(prefab);

        BoolVariable boolVar = (BoolVariable) ScriptableObject.CreateInstance("BoolVariable");

        paw.GetComponent<InputReceiver>().isBeingTouched = boolVar;
        paw.GetComponent<PawController>().touch = boolVar;

        paw.GetComponent<ComingState>().plateTransform = plate.transform;
        paw.GetComponent<LeavingState>().plateTransform = plate.transform;
        paw.GetComponent<DraggingState>().mainCamera = _camera;

        StartCoroutine(Spawn());
    }
}
