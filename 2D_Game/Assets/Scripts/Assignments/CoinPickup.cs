using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : GenericPickup {

	public GameObject PC; 
	

	void OnTriggerEnter2D(Collider2D other){
		if(other.name == "PC"){
			//player collects coin 
		}
		else{
			// not player
		}

	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
