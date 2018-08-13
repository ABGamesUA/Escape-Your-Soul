using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {
	public GameObject moveEffect;
	public GameObject restartUI;	
	public AudioClip [] pop;
	Vector2 newPosition;
	float increment = 5f;
	public float speed = 500f;	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {		
		if(PlayerStats.health <= 0)
		{			
			restartUI.SetActive(true);
			Instantiate(moveEffect, transform.position, Quaternion.identity);
			Destroy(gameObject);
		}	
		transform.position = Vector2.MoveTowards(transform.position, newPosition, Time.deltaTime * speed);
		if((Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)) && transform.position.y < increment)
		{
			PlaySound();
			Shake.instance.CamShake();
			Instantiate(moveEffect, transform.position, Quaternion.identity);
			newPosition.y = transform.position.y + increment;
		}
		if((Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S)) && transform.position.y > -increment)
		{
			PlaySound();
			Shake.instance.CamShake();
			Instantiate(moveEffect, transform.position, Quaternion.identity);
			newPosition.y = transform.position.y - increment;
		}		
	}

	void PlaySound()
	{
		int i = Random.Range(0, pop.Length);
		SoundManager.instance.PlayMoveEff(pop[i]);
	}
	
}
