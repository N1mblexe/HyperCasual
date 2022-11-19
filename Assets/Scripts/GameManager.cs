using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int carNumbers = 1;
    public int carYear = 1;
    [SerializeField] ParticleSystem splashParticle;
    public int level = 0;

    public bool gameRunning = true;

    private void OnTriggerEnter(Collider obj)
    {
        if(obj.tag == "Car" || obj.tag == "Buffer") AddBuff(obj);
        if (obj.tag == "EndLevel")
        {

        }
    }
    private void Awake()
    {
        level = SceneManager.GetActiveScene().buildIndex;       
    }
    public void AddBuff(Collider obj)
    {
        if (obj.gameObject.tag == "Buffer")
        {
            if(obj.GetComponent<BufferManager>().yearMultipler) carYear *= (int)obj.GetComponent<BufferManager>().buffYear;
            else carYear += (int)obj.GetComponent<BufferManager>().buffYear;
            splashParticle.transform.position = obj.transform.position;
            splashParticle.Play();
            Destroy(obj.gameObject);
        }
        if (obj.gameObject.tag == "Car")
        {
            if(obj.GetComponent<BufferManager>().carNumbersMultipler) carNumbers *= (int)obj.GetComponent<BufferManager>().buffCarNumbers;
            else carNumbers += (int)obj.GetComponent<BufferManager>().buffCarNumbers;
            splashParticle.transform.position = obj.transform.position;
            splashParticle.Play();
            Destroy(obj.gameObject);
        }
    }

    private void Update()
    {
        if(carNumbers < 1 || carYear < 1)
        {
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            GetComponent<Movement>().enabled = false;
            Debug.Log(gameRunning);
            gameRunning = false;
            if (Input.GetMouseButtonDown(0))
                SceneManager.LoadScene(level);
        }
    }
}