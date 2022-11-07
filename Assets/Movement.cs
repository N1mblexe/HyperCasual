using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float deltaTouch;
    [SerializeField] Vector2 oldTouchPos = Vector2.zero;
    private void Update()
    {
        Debug.Log(swipe());
    }

    int swipe()
    {
        if (Input.touches.Length == 1)
        {
            if (oldTouchPos != Vector2.zero)
            {
                deltaTouch = Input.touches[0].position.x - oldTouchPos.x;
                oldTouchPos = Input.touches[0].position;

            }
            else
                oldTouchPos = Input.touches[0].position;
        }
        return 0;
    }
}
