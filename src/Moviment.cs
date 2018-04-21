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

		// Toggle moving animation
		if(Input.GetKey(KeyCode.W)) moviment.SetBool("moving", true);
		if(Input.GetKeyUp(KeyCode.W)) moviment.SetBool("moving", false);

		// Toggle run or walking
		if (Input.GetKeyUp (KeyCode.Slash)) {
			if (moviment.GetBool("toRun") == true) moviment.SetBool ("toRun", false);
			else moviment.SetBool ("toRun", true);
		}

	}
}
