using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] GameObject objectToFollow; //camera gonna follow this shit object
    [SerializeField] GameObject objectToLook;
    public bool gameStarted = false;
    double myTimer = 0;

    public Vector3 distance = new Vector3(-4, -1.2f, 0); //my own cinemachine go brrrr

    private void Update() //unity calls this function once per frame
    {
        distance.z = objectToFollow.transform.position.z; //locking z axis
        transform.position = objectToFollow.transform.position - distance; //setting position of camera

    }
    
}
//-4  -1.2
//-5 , -5