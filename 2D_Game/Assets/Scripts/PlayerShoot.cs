using UnityEngine;
using System.Collections;

public class PlayerShoot : MonoBehaviour {
	public Transform firePoint;
	public GameObject projectile;
	
	void Start(){
		// Load Projectile from Resources/Prefabs Folder
		projectile = Resources.Load("Prefabs/Projectile") as GameObject;
	}
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.RightControl))
			Instantiate(projectile,firePoint.position, firePoint.rotation);
		
	}
}