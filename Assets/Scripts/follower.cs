using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follower : MonoBehaviour
{
    public GameObject linkedObj;
    double yumos = 0.01;
    private void LateUpdate()
    {
        transform.LookAt(linkedObj.transform);
        yumos += yumos > 1 ? -yumos : 0.00008;
        transform.position = new Vector3(
            linkedObj.transform.position.x + transform.localScale.y * 1.1f,
            transform.position.y,
            transform.position.z);         
        transform.position = Vector3.Lerp(
                transform.position,
                new Vector3(linkedObj.transform.position.x + transform.localScale.y * 1.1f, linkedObj.transform.position.y, linkedObj.transform.position.z),
                (float)yumos);
    }
}
