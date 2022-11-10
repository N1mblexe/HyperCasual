using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follower : MonoBehaviour
{
    public GameObject linkedObj;
    double lerp = 0.01;
    private void LateUpdate()
    {
        lerp += lerp > 1 ? -lerp : 0.00008;
        transform.position = new Vector3(
            linkedObj.transform.position.x + transform.localScale.y * 1.1f,
            transform.position.y,
            transform.position.z);         
        transform.position = Vector3.Lerp(
                transform.position,
                new Vector3(linkedObj.transform.position.x + transform.localScale.y * 1.1f, linkedObj.transform.position.y, linkedObj.transform.position.z),
                (float)lerp);
    }
}
