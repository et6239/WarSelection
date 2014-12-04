using UnityEngine;
using System.Collections;

public class Sprint : MonoBehaviour {

	CharacterMotor cm;
	float oldMoveSpeed;
	public float SprintForwardSpeed = 50;

	// Use this for initialization
	void Start () {
		cm = GetComponent ("CharacterMotor") as CharacterMotor;
	
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
	}
}
