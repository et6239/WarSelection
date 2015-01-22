using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MyAnimationStateController : MonoBehaviour {

	public string triggerName = "pausebutton"; 
	public bool triggerOnStart = true;
	public List<GameObject> thingsToToggle;

	void ToggleUI() {
		Animator a = GetComponent<Animator>();
		a.SetTrigger(triggerName);
		if(thingsToToggle != null) {
			for(int i = 0; i < thingsToToggle.Count; ++i) {
				thingsToToggle[i].SetActive( !thingsToToggle[i].activeSelf );
			}
		}
	}

	// Use this for initialization
	void Start () {
		if(triggerOnStart) {
			ToggleUI();
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape)) {
			ToggleUI();
		}
	}
}
