using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{
    [SerializeField] float deltaTouch; //distance between old touch position and new one
    [Range(1,20)] public float speed = 0; //speed to righ and left
    [SerializeField] Vector2 oldTouchPos = Vector2.zero; //before frame touch pos
    [SerializeField] float ZPos;//my z axis (to clamp z axis)(to not fall from map)
    [Range(1, 2000)]public float forwardSpeed = 0;//forward speed u stupid
    public Rigidbody rb;//physics

    private void Start()//uniy calls this function once in starting script
    {
        rb = GetComponent<Rigidbody>();//setting rb
        ZPos = transform.position.z;//setting zPos to z position
        rb.velocity = new Vector3(-1 * forwardSpeed * Time.deltaTime , 0 , 0);//setting forward speed
    }

    private void Update() //unity calls this function once per frame
    {
        SetPosition(-4 , 4);//setting player pos in every frame
    }
    
    void SetPosition(float min , float max)//min and max for clamping
    {
        
        ZPos += Swipe() * Time.deltaTime * speed;
        ZPos = Mathf.Clamp(ZPos, min, max);
        transform.position = new Vector3(transform.position.x, transform.position.y, ZPos);
    }

    float Swipe()//I'm not gonna explain wtf is this(read it yourself)
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
            {
                oldTouchPos = Input.touches[0].position;
            }
        }
        else 
        {
            deltaTouch = 0;
            oldTouchPos = Vector2.zero;
        }
            
        return deltaTouch;
    }
}
