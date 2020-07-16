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

        public Vector3Variable platePosition;
        public FloatVariable minTime;
        public FloatVariable maxTime;
        public float distance;

        private bool _hasLoaded = false;

        private Coroutine _spawnRoutine = null;

        public void InitSpawn()
        {
            if (!_hasLoaded)
            {
                _prefabPool = new List<GameObject>();

                for (int i = 0; i < poolSize; i++)
                {
                    GameObject paw = Instantiate(prefab);
                    paw.SetActive(false);
                    _prefabPool.Add(paw);
                }
                _hasLoaded = true;
            }

            _spawnRoutine = StartCoroutine(Spawn());
        }

        public void StopSpawn()
        {
            if(_spawnRoutine != null)
            {
                StopCoroutine(_spawnRoutine);
            }
        }

        private GameObject RetrieveObject()
        {
            for (int i = _prefabPool.Count - 1; i >= 0 ; i--)
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
            float time = Random.Range(minTime.Value, maxTime.Value);

            GameObject paw = RetrieveObject();

            if (paw != null)
            {
                Vector3 spawpoint = distance * Vector3.up;
                float ramdomAngle = Random.Range(-55, 55);
                spawpoint = Quaternion.Euler(0, 0, ramdomAngle) * spawpoint;

                paw.transform.position = platePosition.Value + spawpoint;
                paw.SetActive(true);
            }
            else
            {
                Debug.Log("Pool limit reached");
            }

            yield return new WaitForSeconds(time);

            _spawnRoutine = StartCoroutine(Spawn());
        }

    }
}
