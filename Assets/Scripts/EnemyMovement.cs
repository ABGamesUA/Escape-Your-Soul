using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {
	public float speed = 15f;
	public float deleter = 20f;
	public GameObject deathEffect;
	public AudioClip puf;
	
	private void Start()
	{
		speed += Time.timeSinceLevelLoad / deleter;
	}
	// Update is called once per frame
	void Update () {
		if(transform.position.x <= -27f) Destroy(gameObject);		
		transform.position = transform.position + Vector3.left * Time.deltaTime * speed; 
	}

	private void OnTriggerEnter2D(Collider2D other)
	{		
		if(other.gameObject.tag == "Player")
		{	
			SoundManager.instance.PlayEnemyEff(puf);
			Shake.instance.CamShake();
			Instantiate(deathEffect, transform.position, Quaternion.identity);			
			PlayerStats.health--;
			Destroy(gameObject);
		}
		if(other.gameObject.tag == "GameController")
		{
			PlayerStats.score++;
		}
	}
}
