using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]

public class BallMovment : MonoBehaviour
{
    private const string AnimationPlayerRun = "Run";

    [SerializeField] private float _movment;

    private SpriteRenderer _renderer;

    private void Start()
    {
        _renderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(_movment * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(_movment * Time.deltaTime * -1, 0, 0);
        }
    }
}
