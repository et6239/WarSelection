using UnityEngine;
using System.Collections;

public class ShowMenuOnKeypress : MonoBehaviour {

	Canvas canvas;

	public KeyCode menuButton = KeyCode.Escape;

	// Use this for initialization
	void Start () {
		canvas = GetComponent<Canvas> ();
		canvas.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(menuButton)) {
			canvas.enabled = !canvas.enabled;
			MouseLook.ALLOW_MOUSE_INPUT = !canvas.enabled;
		}
	}
}
