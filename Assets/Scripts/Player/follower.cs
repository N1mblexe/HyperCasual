using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follower : MonoBehaviour
{
    public GameObject linkedObj;
    double yumos = 0.01;
    public bool end = false;
    public double yumos2 = 0.01f;
    private void LateUpdate()
    {
        if (!end) calculate();
        else
        {
            Debug.Log(yumos2);
            if (yumos2 < 1)
            {
                yumos2 += 0.02;
                Vector3.Lerp(transform.position,
                    new Vector3(transform.position.x, transform.position.y, 0),
                    (float)yumos2);
                transform.eulerAngles = new Vector3(-60, 90, -90);
                GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
            }
            else
            {
                GetComponent<Rigidbody>().AddForce(-transform.right * 10);
            }
        }
    }


    void calculate()
    {
        transform.LookAt(linkedObj.transform);
        yumos += yumos > 1 ? -yumos : 0.00008;
        transform.position = new Vector3(
            linkedObj.transform.position.x + transform.localScale.y * 1.4f,
            transform.position.y,
            transform.position.z);
        transform.position = Vector3.Lerp(
                transform.position,
                new Vector3(linkedObj.transform.position.x + transform.localScale.y * 1.1f, transform.position.y, linkedObj.transform.position.z),
                (float)yumos);
    }

        
}
