using UnityEngine;
using System.Collections;
using System;

// TODO finish from Non-Authoratitive/Authoratitive Server

public class Spawner2 : MonoBehaviour {

	public Transform playerPrefab;
	public ArrayList playerScripts = new ArrayList();

	void OnServerInitialized()
	{
		SpawnPlayer(Network.player);
	}

	void OnPlayerConnected(NetworkPlayer player)
	{
		SpawnPlayer(player);
	}

	void SpawnPlayer(NetworkPlayer player)
	{
		string tempPlayerString = player.ToString();
		int playerNumber = Convert.ToInt32(tempPlayerString);

		Transform newPlayerTransform = (Transform)Network.Instantiate(
			playerPrefab, transform.position, transform.rotation, playerNumber);
		playerScripts.Add(newPlayerTransform.GetComponent("cubeMoveAuthoritative"));
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
