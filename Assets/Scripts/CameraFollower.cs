using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    public Vector3 distance = Vector3.zero;
    GameObject objToFollow;
    private void Awake()
    {
        Calculate();
        transform.LookAt(new Vector3(objToFollow.transform.position.x,0,0));
    }
    void Update()
    {
        Calculate();
    }

    void Calculate()
    {
        objToFollow = GameObject.FindGameObjectWithTag("player");
        transform.position = objToFollow.transform.position - distance;
        transform.position = new Vector3(transform.position.x, transform.position.y, 0);
    }


}
