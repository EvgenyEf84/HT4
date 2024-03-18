using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    private float _speed = 0.03f;

    private void Update()
    {
        var direction = transform.forward.normalized;
        transform.Translate(direction * _speed);
    }
}
