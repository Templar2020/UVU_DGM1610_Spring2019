using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour {

	public int coinValue;

	void OnTriggerEnter2D (Collider2D other){
		if(other.name == "Player"){

			print("You've Collected the coin!");

			Destroy(gameObject);

		}

	}
	
}
