using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionSystem : MonoBehaviour
{
    [SerializeField] private List<GameObject> Missions;
   
    public static int cash = 0, diamond=0;
    private void Start()
    {
        
    }
    private void Update()
    {
        
    }
    bool MaxCarMission(int CarNumber)
    {
        if (PlayerPrefs.GetInt("maxCar") >= CarNumber)
        {
            return true;
        }
        else return false;
    }
    public void MaxCarMissionButton(int Cash)
    {
        if (MaxCarMission(10))
        {
            cash += Cash;
        } 

    }
}
