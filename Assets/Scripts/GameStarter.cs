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
    bool gameWaiter = true;

    private void Start()
    {
        cam =Camera.main.GetComponent<CameraMovement>();
        movement = GetComponent<Movement>();
    }
    private void Update()
    {
        if(gameWaiter) StartCoroutine(GameWaiter());
        if(!gameStarted && !coroutine && !gameWaiter)
        {
            if (Input.GetMouseButtonDown(0))
            {
                coroutine = true;
                StartCoroutine(LerpCamera());
                movement.enabled = true;
            }
        }
    }

    IEnumerator GameWaiter()
    {
        yield return new WaitForSeconds(1.5f);
        gameWaiter = false;
    }

    IEnumerator LerpCamera()
    {
        cam.distance = Vector3.Lerp(cam.distance, new Vector3(-2, -6.3f, 0), lerpValue);
        yield return new WaitForSeconds(Time.deltaTime);
        Camera.main.transform.LookAt(new Vector3(transform.position.x , transform.position.y ,0));
        lerpValue += Time.deltaTime * 0.05f;
        if (lerpValue < 1) StartCoroutine(LerpCamera());
        else yield break;
    }
}


