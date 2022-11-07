using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] GameObject objectToFollow;
    
    public Vector3 distance;

    private void Update()
    {
        distance.z = objectToFollow.transform.position.z;
        transform.position = objectToFollow.transform.position - distance;
    }
}
