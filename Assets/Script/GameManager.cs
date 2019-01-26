using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public GameObject building;
    public static bool PoliceStartTimer=false;
    public GameObject car;
    public static bool PoliceAvailable = true;
    public static bool firefighter = true;
    public static bool tecnic = true;
    public static bool ambulance = true;
    public float time;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(PoliceStartTimer==true)
        {
            Police.WorkTime = Time.deltaTime + Police.WorkTime;
            time = Time.deltaTime + Police.WorkTime;
            if (Police.WorkTime >= 15)
            {
                
                car.SetActive(true);
                PoliceStartTimer = false;
                PoliceAvailable = true;

            }
        }
        
	}
}
