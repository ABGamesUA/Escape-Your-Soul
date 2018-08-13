using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour {	
	public Text healthT;
	public Text scoreT;
	// Update is called once per frame
	void Update () {
		scoreT.text = "SCORE " + PlayerStats.score.ToString();
		healthT.text = "SOULS " + PlayerStats.health.ToString();
			}
}
