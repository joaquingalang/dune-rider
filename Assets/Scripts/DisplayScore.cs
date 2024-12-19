using TMPro;
using TMPro.Examples;
using UnityEngine;

public class DisplayScore : MonoBehaviour
{
    TextMeshPro text;

    void Start()
    {   
        text = GetComponent<TextMeshPro>();
    }

    // Update score to most recent value
    void Update()
    {
        text.text = "Score: " + ScoreKeeper.playerScore;
    }
}
