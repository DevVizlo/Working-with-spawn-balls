using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBall : MonoBehaviour
{
    [SerializeField] private GameObject _enemyPrefab;

    private float _timeSpawn = 2f;
    private float _timer;

    void Start()
    {
        _timer = _timeSpawn;
    }

    void Update()
    {
        _timer -= Time.deltaTime;
        if (_timer <= 0) 
        {
            _timer = _timeSpawn;
            Instantiate(_enemyPrefab, transform);
        }
    }
}
