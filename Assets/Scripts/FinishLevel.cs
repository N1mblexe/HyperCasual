using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FinishLevel : MonoBehaviour
{
    Rigidbody rb;
    bool coroutine = false;
    double yumos = 0.01f;
    public CameraPositions cameraPositions;
    public bool savePos = false;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "player")
        {   
            if(!coroutine)
            {
                Camera.main.gameObject.GetComponent<CameraMovement>().enabled = false;
                coroutine = true;
                StartCoroutine(lerpCamera());
            }
            rb = other.GetComponent<Rigidbody>();
            other.GetComponent<follower>().enabled = true;
            other.GetComponent<follower>().end = true;
            other.GetComponent<BoxCollider>().isTrigger = false;
            other.gameObject.transform.eulerAngles = new Vector3(-60, 90, -90);
            rb.velocity = Vector3.zero;
            rb.useGravity = true;
        }
    }

    private void Update()
    {
        if(savePos)
        {
            cameraPositions.pos1 = Camera.main.transform.position;
            savePos = false;
        }
    }

    IEnumerator lerpCamera()
    {
        yield return new WaitForSeconds(Time.deltaTime);
        yumos += yumos > 1 ? 0 : 0.00008;
        Camera.main.gameObject.transform.position = Vector3.Lerp(Camera.main.gameObject.transform.position, cameraPositions.pos1, (float)yumos);
        if (yumos >= 1)
        {
            yumos = 0;
            yield break; 
        }
        StartCoroutine(lerpCamera());
    }
}
