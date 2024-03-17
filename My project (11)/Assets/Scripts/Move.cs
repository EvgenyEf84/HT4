using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private void Update()
    {
        var nextPosition = transform.position;
        nextPosition.z += 0.02f;
        transform.position = nextPosition;
    }
}
