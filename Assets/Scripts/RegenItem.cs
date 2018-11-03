using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegenItem : MonoBehaviour { //should be on ground collider

    public GameObject originalItem;
    public Vector3 spawnLocation;
    public GameObject instantiatedObject;



    // Use this for initialization
    void Start () {
        spawnLocation = originalItem.transform.position;
        instantiatedObject.transform.position = spawnLocation;
    }

    public GameObject OnTriggerEnter(Collider item) //item is pickaxe or flashlight
    {

        if (item.gameObject.tag == ("Pickaxe") || item.gameObject.tag == ("flashlight"))  //if this item is pickaxe or flashlight
        {
            // Regenitem(item, itemComp); //gameobject.name
            originalItem = item.gameObject;

            instantiatedObject = (GameObject) Instantiate(originalItem);
            
            
            
            
        }

        Destroy(originalItem);

        return instantiatedObject;

    }


    // Update is called once per frame
    void Update () {
	}


}
