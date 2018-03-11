using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class Scoreboard : MonoBehaviour {
    static Text scoreText;
    static string currentValue;

    void Start() {
        scoreText = GameObject.FindGameObjectWithTag("ScoreText").GetComponent<Text>();
        UpdateScore(currentValue);
    }

    public static void UpdateScore(string addedValue)
    {
        scoreText.text = addedValue;
    }
}