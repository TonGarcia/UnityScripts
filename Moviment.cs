using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moviment : MonoBehaviour {

	private Animator moviment;

	// Use this for initialization
	void Start () {

		moviment = this.GetComponent<Animator> ();
		
	}
	
	// Update is called once per frame
	void Update () {

		// Toggle forward animation
		if(Input.GetKey(KeyCode.W)) moviment.SetBool("forward", true);
		if(Input.GetKeyUp(KeyCode.W)) moviment.SetBool("forward", false);

		// Toggle back animation
		if(Input.GetKey(KeyCode.S)) moviment.SetBool("backward", true);
		if(Input.GetKeyUp(KeyCode.S)) moviment.SetBool("backward", false);

		// Toggle run or walking
		if (Input.GetKeyUp (KeyCode.Slash)) {
			if (moviment.GetBool("toRun") == true) moviment.SetBool ("toRun", false);
			else moviment.SetBool ("toRun", true);
		}

	}
}
