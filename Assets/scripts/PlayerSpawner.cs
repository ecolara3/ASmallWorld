using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour {

    public GameObject player;

    public float StallTime = 0F;

    public static bool playerAlive = false;

	void Start () {

        SpawnPlayer();

    }


	void Update () {
        if(!playerAlive){
            SpawnPlayer();
        }
	}



    public void SpawnPlayer(){

        if(!playerAlive){
			GameObject playerObject = Instantiate(player) as GameObject;
            playerObject.transform.position = new Vector3(-6, 0, 0);
            playerAlive = true;
            Debug.Log("Spawn has been called");
        }

    }

}
