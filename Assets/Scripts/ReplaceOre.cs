using System.Collections;
using UnityEngine;

public class ReplaceOre : MonoBehaviour {

    public GameObject ore;
    public GameObject diamond;
    
    
  
    // Use this for initialization
    void Start () {
        ore = GameObject.Find("UnbrokenOre");
        diamond = GameObject.Find("Diamond");
        ore.SetActive(true);
        diamond.SetActive(false);
        
}

    public void ReplaceWithDiamond()
    {
        ore.SetActive(false);
        diamond.SetActive(true);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider coll)
    {
        if (coll.CompareTag("Pickaxe"))
        {
            ReplaceWithDiamond();
        }

    }
}
