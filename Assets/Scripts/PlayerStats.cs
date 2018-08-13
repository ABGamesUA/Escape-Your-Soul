using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {
	public static int health;
	public static int score;

	private void Start()
	{
		health = 5;
		score = 0;
	}
	
}
