using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour {
	/// health
	public float hp = 10, maxhp = 10;

	public UnityEngine.UI.Image hpBar;
	public UnityEngine.UI.Text hpText;
	float healthBarStart;

	/// for sprinting and attacks and jumps (all physical activity)
	public float stamina;
	/// magic points
	public float mp;
	/// attack score
	public float att;
	/// defense score
	public float def;
	/// dexterity
	public float dex;
	/// wisdom
	public float wis;
	/// vitality
	public float vit;
	/// speed
	public float spd;

	// Use this for initialization
	void Start () {
		healthBarStart = 0;// hpBar.rectTransform.anchoredPosition.x;
	}

	void addHP(int hpAdjustment) {
		hp += hpAdjustment;
		hpText.text = "Current HP: " + hp;
		Vector2 pos = hpBar.rectTransform.anchoredPosition;
		pos.x = hp - maxhp;//hp + healthBarStart - maxhp;
		hpBar.rectTransform.anchoredPosition = pos;
	}

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.F)) {
			addHP(-1);
		}
		if(Input.GetKeyDown(KeyCode.G)) {
			addHP(+1);
		}
	}
}
