using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicScrip : MonoBehaviour
{
    public int playerScore;
    public void addScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        Debug.Log(playerScore.ToString());
    }
    public void GameOver()
    {
        Time.timeScale = 0;
    }

}
