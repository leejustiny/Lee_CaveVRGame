using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnFlashOn : MonoBehaviour {

    public GameObject flashlight;
    public GameObject spotlight;
    //public Component beamlight;
    

    // Use this for initialization
    void Start () {
		flashlight = GameObject.FindWithTag("flashlight");
        spotlight = GameObject.FindWithTag("spotlight");


        spotlight.GetComponent<Light>().enabled = (false);
    }



    // Update is called once per frame
    void Update () {
		
	}

    void onTriggerEnter(Collider hand)
    {
        if (hand.CompareTag("hand"))
        {

            spotlight.GetComponent<Light>().enabled = (true);
        }

    }
}
