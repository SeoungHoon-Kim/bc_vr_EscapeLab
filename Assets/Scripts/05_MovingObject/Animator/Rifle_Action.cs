using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifle_Action : MonoBehaviour {

	Animator ani;
	// Use this for initialization
	void Start () {
		ani = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.B)){
			ani.SetTrigger("Rifle");
		}


		
	}
}
