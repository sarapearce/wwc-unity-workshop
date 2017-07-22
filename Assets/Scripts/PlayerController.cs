using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	//add a speed variable that we can manipulate in the Inspector
	public float speed;

	//Rigidbody is used for objects that require physics
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
