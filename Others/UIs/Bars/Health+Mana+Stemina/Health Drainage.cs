using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthDrainage : MonoBehaviour {

	public RectTransform healthDrain;
	private float cachedY;
	public float maxXValue;
	public float minXValue;
	private int currentHealth;
	public int maxHealth;
	public Text healthText;
	public Image visualHealth;

	// Use this for initialization
	void Start () {

		cachedY = healthDrain.position.y;
		maxXValue = healthDrain.position.x;
		minXValue = healthDrain.position.x - healthDrain.rect.width;
		currentHealth = maxHealth;
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	private void handleHealth()
	{
		
		healthText.text = "Current Health: " + currentHealth;

//		float currentXValue = MapValues(currentHealth, 0, maxHealth, minXValue, maxXValue);

		healthDrain.position = new Vector3 (currentXValue, cachedY);
	}

	private void MapValues(float x, float inMin, float inMax, float outMin, float outMax){
	
		return (x - inMin) * (outMax - outMin) / (inMax - inMin) + outMin;
	
	}

}
