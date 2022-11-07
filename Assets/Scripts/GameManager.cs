using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
  
    private void OnTriggerEnter(Collider obj)
    {
        if (obj.gameObject.tag=="Buffer")
        {
            Debug.Log("AAAAAAAAAAAAAAAA");
        }
        
    }
}
