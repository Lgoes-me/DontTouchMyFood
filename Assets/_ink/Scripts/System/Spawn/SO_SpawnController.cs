using System.Collections.Generic;
using UnityEngine;
using ScriptableObjectArchitecture;

namespace Ink.DontTouchMyFood.System.Spawn
{
    [CreateAssetMenu(fileName = "SpawnController", menuName = "Managers/Spawn", order = 1)]
    public class SO_SpawnController : ScriptableObject
    {
        public GameObject spawnPrefab;
        public int poolSize;
        private List<GameObject> _prefabPool;

        public BoolVariable canSpawn;

        public Vector3Variable centerPosition;
        public float distanceFromCenter;

        public void Init()
        {
            _prefabPool = new List<GameObject>();

            for (int i = 0; i < poolSize; i++)
            {
                GameObject spawn = Instantiate(spawnPrefab);
                spawn.SetActive(false);
                _prefabPool.Add(spawn);
            }
        }
        
        public void Spawn()
        {
            if (canSpawn)
            {
                GameObject spawn = RetrieveObject();

                if (spawn != null)
                {
                    Vector3 spawpoint = distanceFromCenter * Vector3.up;
                    float ramdomAngle = Random.Range(-125, 125);
                    spawpoint = Quaternion.Euler(0, 0, ramdomAngle) * spawpoint;

                    spawn.transform.position = centerPosition.Value + spawpoint;
                    spawn.SetActive(true);
                }
                else
                {
                    Debug.Log("Pool limit reached");
                }
            }
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
    }
}
