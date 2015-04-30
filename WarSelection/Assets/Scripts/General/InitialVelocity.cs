using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Rigidbody))] 
public class InitialVelocity : MonoBehaviour 
{
	public float speed = 100;
	public Vector3 initialVelocity;
	void Start ()
	{

		if (GetComponent<Rigidbody>().velocity == Vector3.zero) 
		{
       			GetComponent<Rigidbody>().velocity = transform.forward * speed;
		}
	}
}