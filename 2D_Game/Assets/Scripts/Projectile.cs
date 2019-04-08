using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

	public float speed;

	public float timeOut;

	public GameObject player;

	public GameObject enemyDeath;

	public GameObject projectileParticle;

	public int pointsForKill;

	// Use this for initialization
	void Start () {
		 player = GameObject.Find("Player"); 

		 enemyDeath = Resources.Load("Prefabs/Death_PS") as GameObject;

		 projectileParticle = Resources.Load("Prefabs/Respawn_PS") as GameObject;

		if(player.transform.localScale.x < 0)
			speed = -speed;			

		// Destroys Projectile after X seconds
		Destroy(gameObject,timeOut);
						
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody2D>().velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y);
	}

	void OnTriggerEnter2D(Collider2D other){
		//Destroys enemey on contact with projectile. Adds points. 
		if(other.tag == "Enemy"){
			Instantiate(enemyDeath, other.transform.position, other.transform.rotation);
			Destroy (other.gameObject);
			ScoreManager.AddPoints (pointsForKill);
		}
		
		
		// Instantiate(ProjectileParticle, transform.position, transform.rotation);

		//Destroy projectile after hitting the enemy.
		Destroy (gameObject);
	}
	//OnCollision with object in the environment
	void OnCollisionEnter2D(Collision2D other)
	{
		Instantiate(projectileParticle, transform.position, transform.rotation);
		Destroy (gameObject);
		
	}
}