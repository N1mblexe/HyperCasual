using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Joystick : MonoBehaviour
{
    public static Vector3 firstTouchPos = Vector3.positiveInfinity;

    public static List<GameObject> wheels;
    
    static Vector3 moveData;
    
    public static bool isPressing = false;

    public static int forwardSpeed = 10;
    public static int sideSpeed = 20;

    private void Awake()
    {
        EndJoystick();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
            StartJoystick();
        else if (Input.GetMouseButtonUp(0))
            EndJoystick();
        if (isPressing)
            moveData = Input.mousePosition - firstTouchPos;
        else
            moveData = Vector3.zero;
    }

    void StartJoystick()
    {
        isPressing = true;
        firstTouchPos = Input.mousePosition;
    }

    void EndJoystick()
    {
        isPressing = false;
        firstTouchPos = Vector3.positiveInfinity;
    }

    public static Vector3 ClampMoveData(Vector3 min , Vector3 max)
    {
        return NormalizeDirections(new Vector3(
            Mathf.Clamp(moveData.x, min.x, max.x),
            Mathf.Clamp(moveData.y, min.y, max.y),
            Mathf.Clamp(moveData.z, min.z, max.z)
            ));
    }

    public static Vector3 ClampMoveData(float min, float max)
    {
        return NormalizeDirections(ClampMoveData(new Vector3(min, min, min), new Vector3(max, max, max)));
    }
    static Vector3 NormalizeDirections(Vector3 vector)
    {
        return new Vector3(vector.y, vector.z, vector.x);
    }
}
