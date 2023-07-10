using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Transform))]
public class SpawnBall : MonoBehaviour
{
    [SerializeField] private BallDelete _ballPrefab;
    [SerializeField] private Transform _path;

    private Transform[] _points;
    private float _timeSpawn = 2f;

    private void Start()
    {
        _points = new Transform[_path.childCount];

        for (int i = 0; i < _path.childCount; i++)
        {
            _points[i] = _path.GetChild(i);
        }

        StartCoroutine(BallSpawn());
        Instantiate(_ballPrefab);
    }

    private IEnumerator BallSpawn()
    {
        for (int i = 0; i < _points.Length; i++)
        {
            Instantiate(_ballPrefab, _points[i].position, Quaternion.identity);
            yield return new WaitForSeconds(_timeSpawn);
        }
        
    }
}
