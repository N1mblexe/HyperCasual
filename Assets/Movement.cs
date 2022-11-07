using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float deltaTouch;
    [Range(1,20)][SerializeField] float speed;
    [SerializeField] Vector2 oldTouchPos = Vector2.zero;
    [SerializeField] float ZPos;
    private void Update()
    {
        SetPosition(-5 , 5);
    }
    private void Start()
    {
        ZPos = transform.position.z;
    }
    void SetPosition(float min , float max)
    {
        ZPos += Swipe() * Time.deltaTime * speed;
        ZPos = Mathf.Clamp(ZPos, min, max);
        transform.position = new Vector3(transform.position.x, transform.position.y, ZPos);
    }

    float Swipe()
    {
        if (Input.touches.Length == 1)
        {
            if (oldTouchPos != Vector2.zero)
            {
                if (oldTouchPos == Input.touches[0].position)
                    return 0;
                deltaTouch = Input.touches[0].position.x - oldTouchPos.x;
                oldTouchPos = Input.touches[0].position;

            }
            else
                oldTouchPos = Input.touches[0].position;
        }
        return deltaTouch;
    }
}
