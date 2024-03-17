using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    void Update()
    {
        var nextPosition = transform.position;
        nextPosition.z += 0.02f;
        transform.position = nextPosition;
    }
}
