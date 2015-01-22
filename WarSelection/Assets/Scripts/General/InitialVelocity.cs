using UnityEngine;using System.Collections;
[RequireComponent (typeof (Rigidbody))] 
public class InitialVelocity : MonoBehaviour 
{	public float speed = 100;	public Vector3 initialVelocity;	void Start ()	{		if (rigidbody.velocity == Vector3.zero) 
		{       			rigidbody.velocity = transform.forward * speed;		}
	}
}