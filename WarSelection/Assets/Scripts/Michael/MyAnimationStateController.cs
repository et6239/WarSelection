using UnityEngine;
using System.Collections;

public class MyAnimationStateController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape)) {
			Animator a = GetComponent<Animator>();
			a.SetTrigger("pausemenu");
			print ("HEY!!!");
		}
	}
}
