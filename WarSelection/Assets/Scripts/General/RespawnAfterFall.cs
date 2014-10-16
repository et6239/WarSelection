using UnityEngine; 
using System.Collections; 
public class RespawnAfterFall : MonoBehaviour 
{	Vector3 startLocation;	public float lowestAllowedLocation = -20;
	public int numberOfRespawns = 0;       	void Start () 
	{		startLocation = transform.position;
		print ("respawning "+gameObject);       
	}	 public void Respawn()	{		transform.position = startLocation;             
		numberOfRespawns++;        
	}	void Update () 
	{		if (transform.position.y < lowestAllowedLocation) 
		{
			Respawn (); // call the Respawn() function.		}
	}
}