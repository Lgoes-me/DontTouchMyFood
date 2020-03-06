using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScriptableObjectArchitecture;

public class SpawnController : MonoBehaviour
{
    public GameObject prefab;
    public Vector3Variable platePosition;
    public float minTime;
    public float maxTime;
    public float distance;

    private Camera _camera;

    private void Awake()
    {
        _camera = Camera.main;
    }

    public void InitSpawn()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        float time = Random.Range(minTime, maxTime);
        yield return new WaitForSeconds(time);
        GameObject paw = Instantiate(prefab);

        Vector3 spawpoint = distance * Vector3.up;
        float ramdomAngle = Random.Range(0, 360);
        spawpoint = Quaternion.Euler(0, 0, ramdomAngle) * spawpoint ;

        paw.transform.position = platePosition.Value + spawpoint;

        BoolVariable boolVar = (BoolVariable) ScriptableObject.CreateInstance("BoolVariable");

        paw.GetComponent<InputReceiver>().isBeingTouched = boolVar;
        paw.GetComponent<PawController>().touch = boolVar;

        paw.GetComponent<DraggingState>().mainCamera = _camera;

        StartCoroutine(Spawn());
    }
}
