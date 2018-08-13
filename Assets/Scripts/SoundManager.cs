using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {
	public static SoundManager instance;
	public AudioSource musicBG;
	public AudioSource soundsEff;
	public AudioSource enemyEff;
	// Use this for initialization
	private void Awake()
	{
		if(instance == null) instance = this;
		else if(instance != this) Destroy(gameObject);
		DontDestroyOnLoad(gameObject);
	}	
	
	public void PlayEnemyEff(AudioClip clip)
	{
		enemyEff.clip = clip;
		enemyEff.Play();
	}
	public void PlayMoveEff(AudioClip clip)
	{
		soundsEff.clip = clip;
		soundsEff.Play();
	}
	
}
