using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Item {
    public string name;
    public string decription;
    public bool useable;
}

class Comsumable : Item {
    public int useTime;
    public int maxUseTime;
    public string kind;
}

public class PackageController : MonoBehaviour {
    Dictionary<string, Item> items;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
