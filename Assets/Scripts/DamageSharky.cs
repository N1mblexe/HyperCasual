using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DamageSharky : MonoBehaviour
{
    public GameObject player;
    [SerializeField] TextMeshPro text;
    public float multipler = 1;
    public int health = 100;
    public int damage = 10;
    public int counter = 0;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "player")
        {
            if (health > 0) health -= damage;
            else multipler += Mathf.Log10(++counter)/10;
            Destroy(other.gameObject);
        }
    }

    private void Update()
    {
        if(health < 0) health = 0;
        GetComponent<Renderer>().material.color = new Color((100-health)/100, health / 100, 0, 1);
        text.text = "Health:" + health + "\nMultipler:" + multipler;
    }
}
