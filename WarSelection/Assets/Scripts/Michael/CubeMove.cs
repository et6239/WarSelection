﻿using UnityEngine;
using System.Collections;

public class CubeMove : MonoBehaviour {

	Vector3 lastPosition;
	float minimumMovement = .05f;

	void Awake()
	{
		if (!GetComponent<NetworkView>().isMine)
			enabled = false;
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (GetComponent<NetworkView>().isMine)
		{
			Vector3 moveDir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
			float speed = 5;
			transform.Translate(speed * moveDir * Time.deltaTime);

//			if (Vector3.Distance(transform.position, lastPosition) > minimumMovement)
//			{
//				lastPosition = transform.position;
//				networkView.RPC("SetPosition", RPCMode.Others, transform.position);
//			}
		}
	}

	void OnSerializeNetworkView(BitStream stream, NetworkMessageInfo info)
	{
		if (stream.isWriting)
		{
			Vector3 myPosition = transform.position;
			stream.Serialize(ref myPosition);
		}
		else
		{
			Vector3 receivedPosition = Vector3.zero;
			stream.Serialize(ref receivedPosition); //"Decode" it and receive it
			transform.position = receivedPosition;
		}
	}

	[RPC]
	void SetPosition(Vector3 newPosition)
	{
		transform.position = newPosition;
	}
}
