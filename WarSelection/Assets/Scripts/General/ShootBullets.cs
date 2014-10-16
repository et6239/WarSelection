using UnityEngine;using System.Collections;
public class ShootBullets : MonoBehaviour
{	public GameObject bulletPrefab; 
	public string shootButton = "Fire1"; 
	public float 	bulletInitialSpeed = 10; 
	public float bulletDuration = 3;	void Update () 
	{		if (Input.GetButtonDown (shootButton)) 
		{			GameObject b = (GameObject)Instantiate(				bulletPrefab, transform.position, transform.rotation);			InitialVelocity iv = b.GetComponent<InitialVelocity>(); 				iv.initialVelocity = transform.forward * bulletInitialSpeed; 				Destroy(b, bulletDuration);
		}
	}
}