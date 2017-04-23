using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
    public static int score;        // The player's score.

    private bool increaseDifficulty = false;

    Text text;                      // Reference to the Text component.


    void Awake ()
    {
        // Set up the reference.
        text = GetComponent <Text> ();

        // Reset the score.
        score = 0;
    }


    void Update ()
    {
        // Set the displayed text to be the word "Score" followed by the score value.
        text.text = "Score: " + score;
        int difficultyTest = score % 100;
        Debug.Log(score % 100);
        if (difficultyTest == 0 && score != 0){
            EnemySpawner.enemyStallTime -= .1F;
            score += 10;
            Debug.Log(EnemySpawner.enemyStallTime);
        }
    }
}