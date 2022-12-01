using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    public float jumpSpeed;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "player")
            other.gameObject.GetComponent<Rigidbody>().velocity += new Vector3(0, jumpSpeed, 0);
    }
}
