#region TheCode
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class City : MonoBehaviour {
    #region Variables
    //Arrays
    public GameObject[] FixedCity;
    public GameObject[] FireCity;
    public GameObject[] DisasterCity;
    public GameObject[] RoadCity;
    //indexes
    private int x;
    private int y;
    //Times
    float timegeter;
    float CityTime;
    float Rtime;
    #endregion
    #region RandomDisasterStarter
    //Code Starts
    void Update()
    {

        if (GameManager.Started==true)
        {
            timegeter = Time.deltaTime + timegeter;
            CityTime = Time.deltaTime + CityTime;
            if (timegeter >= 5f)
                RandomTime();
            if (CityTime >= Rtime)
            {
                if (y == 1)
                    randomfire();
                else if (y == 2)
                    randomroad();
                else if (y == 3)
                    randomdisaster();
            }
        }
      

    }

    #endregion
    #region Functions
    //Functions
    public void randomfire()
    {
        x = Random.Range(0, 10);
        FixedCity[x].SetActive(false);
        DisasterCity[x].SetActive(true);
    }
    public void RandomTime()
    {
        y = Random.Range(0, 3);
        Rtime = Random.Range(5f, 15f);
    }
    public void randomroad()
    {
        x = Random.Range(0, 10);
        FixedCity[x].SetActive(false);
        RoadCity[x].SetActive(true);
    }
    public void randomdisaster()
    {
        x = Random.Range(0, 10);
        FixedCity[x].SetActive(false);
        DisasterCity[x].SetActive(true);
    }
    #endregion
}
#endregion
