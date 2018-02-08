using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	private Rigidbody rb;
	private GameObject player;
	public float speed;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		player = GameObject.Find ("Player");
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float moveH = Input.GetAxis ("Horizontal");
		float moveV = Input.GetAxis ("Vertical");
		Vector3 move = new Vector3(moveH,0.0f,moveV);
		rb.AddForce (move * speed, ForceMode.Acceleration);

	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag ("Collectable")) {
			other.gameObject.SetActive (false);
		}
	}
}
