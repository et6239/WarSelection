using UnityEngine;
using System.Collections;

public class Fall : MonoBehaviour {

	Vector3 startLocation;

	public float minimumY = -10;

	// Use this for initialization
	void Start ()
	{
		startLocation = transform.position;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(transform.position.y < minimumY)
		{
			transform.position = startLocation;
		}
	}
}
