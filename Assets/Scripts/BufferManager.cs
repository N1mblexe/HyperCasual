using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BufferManager : MonoBehaviour
{
    public float buffYear;
    public float buffCarNumbers;
    public bool yearMultipler;
    public bool carNumbersMultipler;

    private void Awake() //Coloring cube
    {
        if (gameObject.tag == "Car")
        {
            if(carNumbersMultipler)
            {
                gameObject.GetComponent<Renderer>().material.color = buffCarNumbers < 1 ? Color.red : Color.green;
            }
            else
            {
                gameObject.GetComponent<Renderer>().material.color = buffCarNumbers < 0 ? Color.red : Color.green;
            }
        }
        else if (gameObject.tag == "Buffer")
        {
            if(yearMultipler)
            {
                gameObject.GetComponent<Renderer>().material.color = buffYear < 1 ? Color.red : Color.green;
            }
            else
            {
                gameObject.GetComponent<Renderer>().material.color = buffYear < 0 ? Color.red : Color.green;
            }
        }

    }
}
