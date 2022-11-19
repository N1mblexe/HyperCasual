using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FinishLevel : MonoBehaviour
{
    Rigidbody rb;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "player")
        {
            rb = other.GetComponent<Rigidbody>();
            other.GetComponent<follower>().enabled = true;
            other.GetComponent<follower>().end = true;
            other.GetComponent<BoxCollider>().isTrigger = false;
            other.gameObject.transform.eulerAngles = new Vector3(-60, 90, -90);
            rb.velocity = Vector3.zero;
            rb.useGravity = true;
        }
    }
}
