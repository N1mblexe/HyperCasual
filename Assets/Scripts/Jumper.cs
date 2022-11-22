using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    [Range(1, 50)][SerializeField] int forceSpeed;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "player")
        {
            other.GetComponent<Rigidbody>().velocity = new Vector3(other.GetComponent<Rigidbody>().velocity.x , 10, other.GetComponent<Rigidbody>().velocity.z);
            //TODO
            //Add particle
            //start animation
        }
    }
}
