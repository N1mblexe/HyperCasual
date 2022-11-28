using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissionSystem : MonoBehaviour
{

    public List<GameObject> Missions;
    public Text MissionExample, CashMiktar; 
    public static int cash = 0, diamond=0;
    private void Start()
    {
        PlayerPrefs.SetInt("maxCar", 350);
        PlayerPrefs.SetInt("maxCarMissionPref", 0);
        PlayerPrefs.SetInt("maxYearMissionPref", 0);
        PlayerPrefs.SetInt("maxJumperMissionPref", 0);
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
        if (MaxCarMission(10) && PlayerPrefs.GetInt("maxCarMissionPref") == 0)
        {
            PlayerPrefs.SetInt("maxCarMissionPref", 1);
            cash += Cash;
        } 

    }bool MaxYearMission(int CarNumber)
    {
        if (PlayerPrefs.GetInt("maxCar") >= CarNumber)
        {
            return true;
        }
        else return false;
    }
    public void MaxYearMissionButton(int Cash)
    {
        if (MaxYearMission(10) && PlayerPrefs.GetInt("maxYearMissionPref") == 0)
        {
            PlayerPrefs.SetInt("maxYearMissionPref", 1);
            cash += Cash;
        } 

    }bool MaxJumperMission(int CarNumber)
    {
        if (PlayerPrefs.GetInt("maxCar") >= CarNumber)
        {
            return true;
        }
        else return false;
    }
    public void MaxJumperMissionButton(int Cash)
    {
        if (MaxJumperMission(10) && PlayerPrefs.GetInt("maxJumperMissionPref") == 0)
        {
            PlayerPrefs.SetInt("maxJumperMissionPref", 1);
            cash += Cash;
        } 

    }
}
