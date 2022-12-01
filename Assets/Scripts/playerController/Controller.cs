using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    Vector3 speed;
    private void Update()
    {
        if (gameObject.tag == "player")
        {
            speed = Joystick.ClampMoveData(new Vector3(-100, 0, 0), new Vector3(100, 100, 0));

            speed.x /= Joystick.forwardSpeed;
            speed.z /= -Joystick.sideSpeed;
            speed.y = GetComponent<Rigidbody>().velocity.y;

            if (speed.x < .1f && speed.x > -.1f) speed.x = Mathf.Abs(speed.z / 1.5f);

            GetComponent<Rigidbody>().velocity = speed;
            LookGameObject();
        }
    }

    void LookGameObject()
    {
        Vector3 lTargetDir = transform.position + GetComponent<Rigidbody>().velocity - transform.position;
        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(lTargetDir), 5);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "player")
            gameObject.tag = "player";
        if (collision.gameObject.tag == "enemy")
            Destroy(gameObject);
    }
}
