
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int scoreKeeper;
    public Text scoreText;
    public GameObject end;

    public void addScore(int scoreToAdd)
    {

        scoreKeeper = scoreKeeper + scoreToAdd;
        scoreText.text = scoreKeeper.ToString();
    }

    public void restartGame()
    {
        scoreKeeper = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
    
    public void gameOver()
    {
        end.SetActive(true);
    }
}
