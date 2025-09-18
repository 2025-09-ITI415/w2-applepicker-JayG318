using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // For uGUI classes like Text

public class ScoreCounter : MonoBehaviour
{
    [Header("Dynamic")]
    public int score = 0;
    private Text uiText; // Referencing text from ScoreCounter GameObject

    void Start() // Runs once at start
    {
        uiText = GetComponent<Text>(); // searches GameObject this script is on for the Text component
    }

    
    void Update()
    {
        uiText.text = score.ToString("#,0");
    }
}
