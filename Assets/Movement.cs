using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float deltaTouch;
    public GameObject parent;
    [Range(1,20)][SerializeField] float speed;
    [SerializeField] Vector2 oldTouchPos = Vector2.zero;
    [SerializeField] float ZPos;
    private void Update()
    {
        SetPosition(-4 , 4);
    }
    private void Start()
    {
        ZPos = transform.position.z;
    }
    void SetPosition(float min , float max)
    {
        parent.transform.position += new Vector3(-1, 0, 0) * Time.deltaTime;
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
        else
            deltaTouch = 0;
        return deltaTouch;
    }
}
