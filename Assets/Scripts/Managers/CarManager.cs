using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CarManager : MonoBehaviour
{
    public GameObject cb;
    int counter = 0;
    GameObject temp;
    GameManager gameManager;
    [SerializeField] List<GameObject> cars = new List<GameObject>();
    private void Start()
    {
        gameManager = GetComponent<GameManager>();
        AddCar();
    }

    private void Update()
    {
        if (cars.Count-1 > gameManager.carNumbers && gameManager.gameRunning)
            DeleteCar();
        if (cars.Count-1 < gameManager.carNumbers && gameManager.gameRunning)
            AddCar();
    }

    void AddCar()
    {
        cars.Add(Instantiate(cb));
        Link();
    }
    public void DeleteCar()
    {
        temp = cars[cars.Count - 1];
        cars.Remove(cars[cars.Count - 1]);
        Destroy(temp);
    }

    public void DeleteFrontCar()
    {
        temp = cars[0];
        cars.RemoveAt(0);
        Destroy(temp);
    }


    void Link()
    {
        if (cars.Count == 1)
            cars[cars.Count - 1].GetComponent<follower>().linkedObj = gameObject;
        else
            cars[cars.Count - 1].GetComponent<follower>().linkedObj = cars[cars.Count - 2];
    }
}
