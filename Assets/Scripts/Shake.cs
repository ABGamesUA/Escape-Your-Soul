using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Shake : MonoBehaviour {
	public static Shake instance;
	public Animator camAnim;
	public AudioClip clip;
		public GameObject ui;
	
	
	private void Update()
	{
		if(Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P)) Toggle();
	}
	
	private void Start()
	{
		Time.timeScale = 1;
		instance = this;
	}

	public void CamShake()
	{
		camAnim.SetTrigger("shake");
	}

	public void Play()
	{
		SoundManager.instance.PlayEnemyEff(clip);
		SceneManager.LoadScene("Main");
	}

	public void Restart(){
		Toggle();
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

	public void Menu(){	
		SoundManager.instance.PlayEnemyEff(clip);	
		SceneManager.LoadScene("Menu");
	}

	public void Toggle(){
		SoundManager.instance.PlayEnemyEff(clip);
		ui.SetActive(!ui.activeSelf);
		if(ui.activeSelf) Time.timeScale = 0f;
		else Time.timeScale = 1f;
	}
}
