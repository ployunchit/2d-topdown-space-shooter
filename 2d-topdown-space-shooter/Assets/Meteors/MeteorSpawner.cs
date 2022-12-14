using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{
    float _xMin;
    float _xMax;
    float _ySpawn;
    [SerializeField] GameObject _meteorPrefab;

    // Start is called before the first frame update
    void Start()
    {
        _xMin = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).x;
        _xMax = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, 0)).x;
        _ySpawn = Camera.main.ViewportToWorldPoint(new Vector3(0, 1.25f, 0)).y;

        InvokeRepeating("SpawnMeteor", 0, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnMeteor()
    {
        float randX = Random.Range(_xMin, _xMax);
        Instantiate(_meteorPrefab, new Vector3(randX, _ySpawn, 0), Quaternion.identity);
    }
}
