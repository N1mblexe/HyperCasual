using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarManager : MonoBehaviour
{
    public GameObject cb;
    List<GameObject> cars = new List<GameObject>();
    [SerializeField] float lerp = 0;
    public bool add = false;
    private void Start()
    {
        cars.Add(Instantiate(cb));
    }

    private void Update()
    {
        addCar();
        //followManager();
        followManager();
    }

    void addCar()
    {
        if(add)
        {
            cars.Add(Instantiate(cb));
            add = false;
        }
    }
    void delete()
    {

    }

    void followManager()
    {
        for (int i = 0; i < cars.Count; i++)
        {
            if (i == 0)
                cars[i].transform.position = new Vector3(gameObject.transform.position.x + 1.2f, gameObject.transform.position.y, gameObject.transform.position.z);
            else
                cars[i].transform.position = new Vector3(cars[i - 1].transform.position.x + 1.2f, cars[i - 1].transform.position.y, cars[i - 1].transform.position.z);
             
        }
    }

   //  void followManager()
   //  {
   //      lerp = 0;
   //      StopAllCoroutines();
   //      for (int i = 0; i < cars.Count; i++)
   //      {
   //        if (i == 0)
   //        {
   //            follow(cars[i], gameObject, i);
   //            continue;
   //        }
   //          StartCoroutine(follow(cars[i], cars[i - 1], i));
   //      }
   //  }
   //  IEnumerator follow(GameObject obj , GameObject followObj , int index)
   //  {
   //      obj.transform.position = Vector3.Lerp
   //          (obj.transform.position, 
   //          new Vector3(followObj.transform.position.x - index, followObj.transform.position.y , followObj.transform.position.x),
   //          lerp);
   //      lerp += 0.3f;
   //      if (lerp > 1)
   //      {
   //          lerp = 0;
   //          yield break;
   //      }
   //      yield return new WaitForSeconds(0.2f);
   //      StartCoroutine(follow(obj, followObj , index));
   //  }
}
