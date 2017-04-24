using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ContinueManager : MonoBehaviour
{
    static Text text;                      // Reference to the Text component.

    private static bool endOfGame = false;

    void Awake ()
    {
        // Set up the reference.
        text = GetComponent <Text> ();
        
    }

    void Update(){

        if(endOfGame && Input.anyKey){
            endOfGame = false;
            EnemySpawner.spawnEnemies = true;
            EnemySpawner.enemyStallTime = 1F;
            Application.LoadLevel("TitleScreen");
        }


    }
    public static void continueToTitleScreen(){
        text.text = "(Press any key to continue)";
        endOfGame = true;
        

    }
}