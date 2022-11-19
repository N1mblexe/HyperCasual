using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    #region
    [Header("Objects")]
    [SerializeField] GameObject objectToFollow; //camera gonna follow this shit object
    [SerializeField] GameObject objectToLook;
    [Header("Variables")]
    public bool gameStarted = false;
    public bool realTimeLook = false;
    public Vector3 distance = new(-1.5f, -1.8f, 0); //my own cinemachine go brrrr
    #endregion
    private void Update() //unity calls this function once per frame
    {   
        distance.z = objectToFollow.transform.position.z; //locking z axis
        transform.position = objectToFollow.transform.position - distance; //setting position of camera

        if (realTimeLook)
            transform.LookAt(new Vector3(objectToLook.transform.position.x, objectToLook.transform.position.y, 0));

    }
    
}
//-4  -1.2
//-5 , -5