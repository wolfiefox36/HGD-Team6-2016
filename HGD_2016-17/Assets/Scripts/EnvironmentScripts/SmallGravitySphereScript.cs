using UnityEngine;
using System.Collections;
using System;

public class SmallGravitySphereScript : MonoBehaviour {

	private GameObject player;
	public float strength = 10;

	// Use this for initialization
	void Start () {
		player = GameObject.FindWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		player.GetComponent<Rigidbody2D> ().AddForce ((transform.position - player.transform.position)
			/ ((float)Math.Pow (Vector2.Distance (transform.position, player.transform.position), 4)) * strength);
	}
}
