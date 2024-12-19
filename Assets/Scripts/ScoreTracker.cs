using TMPro;
using TMPro.Examples;
using UnityEngine;

// Tracks user's score throughout a game session

public class ScoreTracker : MonoBehaviour
{
    float score;
    float scoreBuffer;
    TextMeshPro text;

    void Start()
    {   
        text = GetComponent<TextMeshPro>();
        scoreBuffer = Time.time;
    }

    void Update()
    {
        // Displays the current score
        score = (Time.time - scoreBuffer) * 10;
        text.text = "Score: " + (int) score;
    }
}
