using UnityEngine;
using System.Collections;

public class FollowAI : MonoBehaviour {
	
	public GameObject target;

	GameObject followLine, deltaLine, unitV, forwarVector, angleArc;
	public float speed = 3000;

	// Use this for initialization
	void Start () {
		Lines.Make (ref followLine, Color.red, Vector3.zero, 							target.transform.position,1,0);
	
	}
	
	// Update is called once per frame
	void Update () {
		Lines.Make (ref deltaLine, Color.cyan, transform.position, 						target.transform.position, .1f, .1f);
		
		Vector3 delta = target.transform.position -transform.position;
		float distance = delta.magnitude;
//		print (delta + “ which is ” + delta.magnitude + “ long ”);
		Vector3 unitVector = delta.normalized;
		Lines.Make (ref unitV, Color.green, transform.position, transform.position 				+ unitVector, 2, 0);
		if(distance > 5)
		{
			CharacterController cm = GetComponent<CharacterController> ();
			if(cm == null) {
			transform.position += unitVector * speed * Time.deltaTime;
			}else{
				cm.SimpleMove(unitVector * speed);
			}
		}

		Lines.Make(ref forwarVector, Color.blue, transform.position, 						transform.position + transform.forward, .2f, .2f);
	
		float angle = Vector3.Angle (transform.forward, unitVector);
		Vector3 cross = Vector3.Cross (transform.forward, unitVector);
		Lines.MakeArc (ref angleArc, Color.magenta, transform.position, cross, 					transform.forward, angle, 10, .1f, 0);
		transform.rotation = Quaternion.RotateTowards (transform.rotation, 				Quaternion.LookRotation (unitVector), 90 * Time.deltaTime);
	}
}
