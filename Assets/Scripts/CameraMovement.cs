using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] GameObject objectToFollow; //camera gonna follow this shit object
    
    public Vector3 distance; //my own cinemachine go brrrr

    private void Update() //unity calls this function once per frame
    {
        distance.z = objectToFollow.transform.position.z; //locking z axis
        transform.position = objectToFollow.transform.position - distance; //setting position of camera
    }
}
