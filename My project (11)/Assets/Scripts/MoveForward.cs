using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    private float _speed = 0.01f;
    
    void Update()
    {
        var direction = transform.forward.normalized;
        transform.Translate(direction*_speed);
    }
}
