using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject player;

    [Range(1, 20)][SerializeField] float speed = 5;
    [Range(1,20)][SerializeField] float distanceToAttack = 5;

    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if(Vector3.Distance(transform.position , player.transform.position) <= distanceToAttack)
        {
            transform.LookAt(new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z));
            rb.velocity = transform.forward * speed;
        }    
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == player)
        {
            other.GetComponent<GameManager>().carNumbers -= 1;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawSphere(transform.position , distanceToAttack);
    }

}
