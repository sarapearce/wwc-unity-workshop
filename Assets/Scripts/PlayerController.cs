using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed;

	private Rigidbody rb;
		

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}


	// Specific function for physics updates
	void fixedUpdate() {

//		define horizontal and vertical movement
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);


	}
}
