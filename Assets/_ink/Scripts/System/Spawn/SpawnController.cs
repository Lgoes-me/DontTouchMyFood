using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScriptableObjectArchitecture;

namespace Ink.DontTouchMyFood.System.Spawn
{
    public class SpawnController : MonoBehaviour
    {
        public GameObject prefab;
        public int poolSize;
        private List<GameObject> _prefabPool;

        public BoolVariable canSpawn;

        public Vector3Variable platePosition;
        public float minTime;
        public float maxTime;
        public float distance;

        private void Awake()
        {
            _prefabPool = new List<GameObject>();

            for (int i = 0; i < poolSize; i++)
            {
                GameObject paw = Instantiate(prefab);
                paw.SetActive(false);
                _prefabPool.Add(paw);
            }
        }

        public void InitSpawn()
        {
            StartCoroutine(Spawn());
        }

        private GameObject RetrieveObject()
        {
            for (int i = 0; i < _prefabPool.Count; i++)
            {
                if (!_prefabPool[i].activeInHierarchy)
                {
                    return _prefabPool[i];
                }
            }

            return null;
        }

        private IEnumerator Spawn()
        {
            float time = Random.Range(minTime, maxTime);

            yield return new WaitForSeconds(time);

            if (canSpawn)
            {
                GameObject paw = RetrieveObject();

                if (paw != null)
                {
                    Vector3 spawpoint = distance * Vector3.up;
                    float ramdomAngle = Random.Range(-125, 125);
                    spawpoint = Quaternion.Euler(0, 0, ramdomAngle) * spawpoint;

                    paw.transform.position = platePosition.Value + spawpoint;
                    paw.SetActive(true);
                }
                else
                {
                    Debug.Log("Pool limit reached");
                }
            }
            StartCoroutine(Spawn());
        }
    }
}
