using TMPro;
using TMPro.Examples;
using UnityEngine;

public class DisplayHighscore : MonoBehaviour
{
    TextMeshPro text;

    void Start()
    {   
        text = GetComponent<TextMeshPro>();
    }

    void Update()
    {
        // Update highscore to most recent value
        text.text = "Highcore: " + ScoreKeeper.highScore;
    }
}
