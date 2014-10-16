using UnityEngine;
using System.Collections;

public class CreateStuff : MonoBehaviour {

	public GameObject whatToCreate;
	public float distanceToCreateAt;
	public KeyCode keyThatCreatesIt = KeyCode.Alpha1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(keyThatCreatesIt))
		{
			Instantiate(whatToCreate,
			            transform.position+transform.forward * distanceToCreateAt,
			            transform.rotation);
		}
	}
}
