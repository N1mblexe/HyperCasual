using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] int carNumbers = 1;
    [SerializeField] int carYear = 0;
    [SerializeField] ParticleSystem splashParticle;
    private void OnTriggerEnter(Collider obj)
    {
        if (obj.gameObject.tag == "Buffer")
        {
            carYear += obj.GetComponent<BufferManager>().buffYear;
            splashParticle.transform.position = obj.transform.position;
            splashParticle.Play();
            Destroy(obj.gameObject);
        }
        if (obj.gameObject.tag == "Car")
        {
            carNumbers += obj.GetComponent<BufferManager>().buffCarNumbers;
            splashParticle.transform.position = obj.transform.position;
            splashParticle.Play();
            Destroy(obj.gameObject);
        }
    }
}