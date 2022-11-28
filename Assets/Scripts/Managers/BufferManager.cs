using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BufferManager : MonoBehaviour
{
    public float buffYear;
    public float buffCarNumbers;
    public bool yearMultipler;
    public bool carNumbersMultipler;
    [SerializeField] ParticleSystem particle;
    [SerializeField] TextMeshPro infoText;


    private void Awake() //Coloring cube
    {
        var main = particle.main;
        if (gameObject.tag == "Car")
        {
            if(carNumbersMultipler)
            {
                main.startColor = buffCarNumbers < 1 ? new Color(1, 0, 0, 0.5f) : new Color(0, 1, 0, 0.5f);
            }
            else
            {
                main.startColor = buffCarNumbers < 0 ? new Color(1, 0, 0, 0.5f) : new Color(0, 1, 0, 0.5f);
            }
            infoText.text = "Cars\n:" + (carNumbersMultipler? "X" : "+") + buffCarNumbers;
        }
        else if (gameObject.tag == "Buffer")
        {
            if(yearMultipler)
            {
                main.startColor = buffYear < 1 ? new Color(1, 0, 0, 0.5f) : new Color(0, 1, 0, 0.5f);
            }
            else
            {
                main.startColor = buffYear < 0 ? new Color(1, 0, 0, 0.5f) : new Color(0, 1, 0, 0.5f);
            }
            infoText.text = "Year:\n" + (yearMultipler ? "X" : "+") + buffYear;
        }
        

    }
}
