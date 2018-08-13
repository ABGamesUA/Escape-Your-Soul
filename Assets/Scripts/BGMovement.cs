using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMovement : MonoBehaviour {
	public float speed = 5;
	public float startPos = 0;
	public float endPos = 0;

	// Use this for initialization

	
	// Update is called once per frame
	void Update () {
		if(transform.position.x <= endPos) transform.position = new Vector2(startPos, transform.position.y);
		transform.Translate(Vector2.left * Time.deltaTime * speed);
	}
}
