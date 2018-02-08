using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour {

	public float JumpV;
	public GameObject player;
	private Rigidbody rb;

	// Update is called once per frame

	void Awake(){
		rb = GetComponent<Rigidbody> ();
	}

	void Update () {
		if (Input.GetButtonDown ("Jump") && rb.velocity.y == 0) {
			rb.velocity = Vector3.up * JumpV;
		}
	}
}
