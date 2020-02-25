using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScriptableObjectArchitecture;

public class SpawnController : MonoBehaviour
{
    public GameObject prefab;
    public GameObject plate;
    public float minTime;
    public float maxTime;
    public float distance;

    private Camera _camera;

    private void Awake()
    {
        StartCoroutine(Spawn());
        _camera = Camera.main;
    }

    private IEnumerator Spawn()
    {
        float time = Random.Range(minTime, maxTime);
        yield return new WaitForSeconds(time);
        GameObject paw = Instantiate(prefab);

        Vector3 spawpoint = distance * Vector3.up;
        float ramdomAngle = Random.Range(0, 360);
        spawpoint = Quaternion.Euler(0, 0, ramdomAngle) * spawpoint ;

        paw.transform.position = plate.transform.position + spawpoint;

        BoolVariable boolVar = (BoolVariable) ScriptableObject.CreateInstance("BoolVariable");

        paw.GetComponent<InputReceiver>().isBeingTouched = boolVar;
        paw.GetComponent<PawController>().touch = boolVar;

        paw.GetComponent<ComingState>().plateTransform = plate.transform;
        paw.GetComponent<LeavingState>().plateTransform = plate.transform;
        paw.GetComponent<DraggingState>().mainCamera = _camera;

        StartCoroutine(Spawn());
    }
}
