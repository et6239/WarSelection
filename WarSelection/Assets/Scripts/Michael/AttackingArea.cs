using UnityEngine;
using System.Collections;

public class AttackingArea : MonoBehaviour {

	public float attackCooldown = 1;
	public float damage = 5;
	float cooldown;

	// Use this for initialization
	void Start () { }
	
	// Update is called once per frame
	void Update () {
		if(cooldown > 0) {
			cooldown -= Time.deltaTime;
			if(cooldown < 0)
				cooldown = 0;
		}
	}
		
	void OnTriggerStay(Collider other) {
		if(cooldown == 0) {
			PlayerStats ps = other.gameObject.GetComponent<PlayerStats> ();
			if(ps != null) {
				ps.hitpoints.adjust(-damage);
				cooldown = attackCooldown;
			}
		}
	}
}
