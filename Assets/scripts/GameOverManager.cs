using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameOverManager : MonoBehaviour
{
    private bool increaseDifficulty = false;

    static Text text;                      // Reference to the Text component.

    void Awake ()
    {
        // Set up the reference.
        text = GetComponent <Text> ();
        
    }
    public static void SetFinalScore(int score){
        text.text = "Game Over Score: " + score;
    }
}