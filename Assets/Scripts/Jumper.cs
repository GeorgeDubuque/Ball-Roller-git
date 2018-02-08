using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour {

	public float JumpV;
	public GameObject player;
	private Rigidbody rb;
	private bool grounded;

	// Update is called once per frame

	void Awake(){
		rb = GetComponent<Rigidbody> ();
	}

	void Update () {
		Ray downRay = new Ray (player.transform.position, Vector3.down);
		RaycastHit hit;
		Physics.Raycast (downRay, out hit);
		grounded = hit.distance == 0.5;
		if (Input.GetButtonDown ("Jump") && grounded) {
			rb.velocity = Vector3.up * JumpV;
		}
	}
}
