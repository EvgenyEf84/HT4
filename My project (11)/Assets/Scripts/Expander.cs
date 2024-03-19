using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Expander : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        //int increaseNumber = 5;
        //var maxScaleSize = transform.localScale * increaseNumber;
        //transform.localScale += Vector3.Lerp(transform.localScale, transform.localScale , _speed * Time.deltaTime);
        transform.localScale += new Vector3(0.5f, +0.5f, 0.5f) * Time.deltaTime;
    }
}
