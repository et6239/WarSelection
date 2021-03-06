﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour {

	[System.Serializable]
	public class StatWithBar {
		public string name;
		public float current, max;
		public UnityEngine.UI.Image bar;
		public UnityEngine.UI.Text text;

		public void adjust(float adjustment) {
			float totalImageWidth = bar.rectTransform.sizeDelta.x;
			float pixelsPerUnit = totalImageWidth / max;
			current += adjustment;
			if (current > max) 
			{
				current = max;
			}
			if (current < 0) 
			{
				current = 0;
			}
			text.text = name+": " + (int)current + " / " + max;
			Vector2 pos = bar.rectTransform.anchoredPosition;
			pos.x = (current - max) * pixelsPerUnit;
			bar.rectTransform.anchoredPosition = pos;
		}
	}

	public StatWithBar hitpoints;

	/// for sprinting and attacks and jumps (all physical activity)
	public StatWithBar stamina;
	/// magic points
	public StatWithBar mp;
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
		hitpoints.adjust (0);
		stamina.adjust (0);
		mp.adjust (0);
	}

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.F)) {
			hitpoints.adjust(-1);
		}
		if(Input.GetKeyDown(KeyCode.G)) {
			hitpoints.adjust(+1);
		}
	}
}
