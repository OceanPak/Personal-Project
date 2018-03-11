using UnityEngine;
using System.Collections;

public class Scores : MonoBehaviour
{
    float survivalTimeScore;
    float finalScore;
    float highestScore = 0f;
    // Update is called once per frame
    void Start()
    {
        DontDestroyOnLoad(this);
    }

    void Update()
    {
        survivalTimeScore = Time.timeSinceLevelLoad;
        Scoreboard.UpdateScore("" + survivalTimeScore);
    }

    void OnCollisionEnter(Collision coll)
    {
        switch(coll.gameObject.tag)
        {
            case "Asteroid":
                finalScore = survivalTimeScore + 100f; 
                Scoreboard.UpdateScore("" + finalScore);
                if (PlayerPrefs.GetFloat("High") < finalScore)
                {
                    PlayerPrefs.SetFloat("High", finalScore);
                }
                break;
            case "Planets":
                finalScore = survivalTimeScore + 500f;
                Scoreboard.UpdateScore("" + finalScore);
                if (PlayerPrefs.GetFloat("High") < finalScore)
                {
                    PlayerPrefs.SetFloat("High", finalScore);
                }
                break;
        }
        Scoreboard.UpdateScore("Highest Score: " + PlayerPrefs.GetFloat("High"));
    }
}