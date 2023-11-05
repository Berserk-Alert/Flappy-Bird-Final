using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{

    public int playerScore;
    public Text scoreText;


    [ContextMenu("increase score")]
    public void addScore(int scoreIncrement)
    {
        playerScore += scoreIncrement;
        scoreText.text = playerScore.ToString();
    }

}
