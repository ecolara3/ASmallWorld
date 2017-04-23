using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour {

    public GameObject player;

    public float StallTime = 0F;

    public static bool playerAlive = false;

    private bool gameOverSet = false;

    private int numberOfLives = 3;
	void Start () {

        SpawnPlayer();
 
    }


	void Update () {
        if(!playerAlive){
            
            GameObject life = GameObject.Find(numberOfLives.ToString());
            Destroy(life);
            numberOfLives -= 1;

            if(numberOfLives>0){
                SpawnPlayer();
            }else{
                //This is the game over section
                int finalScore = ScoreManager.GetFinalScore();
                GameOverManager.SetFinalScore(finalScore);
                if(!gameOverSet){
                    EnemySpawner.spawnEnemies = false;
                    GameObject.FindGameObjectWithTag("GameMusic").GetComponent<AudioSource>().Stop();
                    GameObject.FindGameObjectWithTag("GameOverMusic").GetComponent<AudioSource>().Play();
                    gameOverSet = true;
                }
                

            }
        }
	}



    public void SpawnPlayer(){

        if(!playerAlive){
			GameObject playerObject = Instantiate(player) as GameObject;
            playerObject.transform.position = new Vector3(-6, 0, 0);
            playerAlive = true;
        }

    }

}
