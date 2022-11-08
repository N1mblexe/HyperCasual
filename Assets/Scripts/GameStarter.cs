using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameStarter : MonoBehaviour
{
    CameraMovement cam;
    Movement movement;
    bool gameStarted = false;
    bool coroutine = false;
    float lerpValue = 0;

    private void Start()
    {
        cam =Camera.main.GetComponent<CameraMovement>();
        movement = GetComponent<Movement>();
    }
    private void Update()
    {
        if(!gameStarted && !coroutine)
        {
            if (Input.touchCount > 0)
            {
                coroutine = true;
                StartCoroutine(LerpCamera());
                movement.enabled = true;
                Debug.Log(movement.enabled);
            }
        }
    }

    IEnumerator LerpCamera()
    {
        cam.distance = Vector3.Lerp(cam.distance, new Vector3(-5, -5, 0), lerpValue);
        yield return new WaitForSeconds(Time.deltaTime);
        Camera.main.transform.LookAt(new Vector3(transform.position.x , transform.position.y ,0));
        lerpValue += Time.deltaTime * 0.7f;
        if (lerpValue < 1) StartCoroutine(LerpCamera());
        else yield break;
    }
}


