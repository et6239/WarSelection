﻿using UnityEngine;
using System.Collections;

public class Sprint : MonoBehaviour {

	CharacterMotor cm;
	PlayerStats ps;
	float oldMoveSpeed;
	public float SprintForwardSpeed = 50;

	// Use this for initialization
	void Start () {
		cm = GetComponent ("CharacterMotor") as CharacterMotor;
		ps = GetComponent<PlayerStats> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.LeftShift)) {
			oldMoveSpeed = cm.movement.maxForwardSpeed;
			cm.movement.maxForwardSpeed = SprintForwardSpeed;
		}
		if(Input.GetKeyUp(KeyCode.LeftShift)) {
			cm.movement.maxForwardSpeed = oldMoveSpeed;
		}
		if(Input.GetKey(KeyCode.LeftShift)) {
			print ("-");
			ps.stamina.adjust(-Time.deltaTime);
		} else {
			print ("+");
			ps.stamina.adjust(+Time.deltaTime);
		}
	}
}
