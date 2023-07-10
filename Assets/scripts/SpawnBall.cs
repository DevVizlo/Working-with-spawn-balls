using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBall : MonoBehaviour
{
    [SerializeField] private BallDelete _ballPrefab;

    private float _timeSpawn = 2f;
    private float _timer;

    void Start()
    {
        StartCoroutine(BallSpawn());
        _timer = _timeSpawn;
        Instantiate(_ballPrefab);
    }

    private IEnumerator BallSpawn()
    {
            yield return new WaitForSeconds(_timeSpawn);
            Instantiate(_ballPrefab, transform);
        
    }
}
