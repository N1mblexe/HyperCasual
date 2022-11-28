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
    [Range(0.5f, 5)][SerializeField]static float x1, y1, z1 , x2 , y2 , z2;
    public Vector3 distance = new(x1, y1, z1); //my own cinemachine go brrrr
    public Vector3 distance2 = new(x2, y2, z2);
    #endregion
    private void Update() //unity calls this function once per frame
    {   
        distance.z = objectToFollow.transform.position.z; //locking z axis
        transform.position = objectToFollow.transform.position - distance; //setting position of camera

        if (realTimeLook)
            transform.LookAt(new Vector3(objectToLook.transform.position.x+10, objectToLook.transform.position.y, 0));

    }
    
}