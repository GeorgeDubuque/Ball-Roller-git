using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetterJump : MonoBehaviour {
	private float fall_multiplier = 2.5f;
	private float low_jump = 2f;
	private Rigidbody rb;

	void Awake(){
		rb = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {

		if (rb.velocity.y < 0) {
			rb.velocity += Vector3.up * Physics.gravity.y * (fall_multiplier - 1) * Time.deltaTime;
		} else if (rb.velocity.y > 0 && !Input.GetButton("Jump")) {
			rb.velocity += Vector3.up * Physics.gravity.y * (low_jump - 1) * Time.deltaTime;
		}
	}
}
