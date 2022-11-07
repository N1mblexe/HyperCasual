using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float deltaTouchPos = 0;
    private void Update()
    {
        if (Input.touches.Length == 1)
        {
            Debug.DrawLine(Vector3.zero, Input.touches[0].position);
        }
    }
}
