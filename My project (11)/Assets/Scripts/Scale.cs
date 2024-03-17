using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Scale : MonoBehaviour
{
    [SerializeField] private float _speed;

    void Update()
    {
        transform.localScale = Vector3.Lerp(transform.localScale, transform.localScale*5, _speed*Time.deltaTime);
    }
}
