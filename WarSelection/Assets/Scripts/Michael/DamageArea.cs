using UnityEngine;
using System.Collections;

public class DamageArea : MonoBehaviour {

	public float damagePerSecond = 2;

	// Use this for initialization
	void Start () { }
	
	// Update is called once per frame
	void Update () { }

	void OnTriggerStay(Collider other) {
		PlayerStats ps = other.gameObject.GetComponent<PlayerStats> ();
		if(ps != null) {
			ps.hitpoints.adjust(-damagePerSecond * Time.deltaTime);
		}
	}
}
