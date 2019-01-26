using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thief : MonoBehaviour {
    public GameObject TheCar;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {


    }
    void OnColisionEnter2D(Collision2D col)
    {
        Debug.Log("Collision");
        if (col.gameObject.tag =="Dozd")
        {
  
            GameManager.PoliceAvailable = false;
            GameManager.PoliceStartTimer = true;
            TheCar.SetActive(false);
        }
  
    }
  
}
