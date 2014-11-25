using UnityEngine;
using System.Collections;

[RequireComponent (typeof (SphereCollider))]
public class NextZone : MonoBehaviour {

	public string nextZone;

	void OnTriggerEnter(Collider other) {
		if(nextZone != null && nextZone.Length > 0
		  && other.gameObject.GetComponent<CharacterController>()) {
			Application.LoadLevel(nextZone);
		}
	}
}
