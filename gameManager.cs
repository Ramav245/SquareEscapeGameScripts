using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class gameManager : MonoBehaviour
{
    public Text scoreText; 
    float score; 
    int highscore; 

    public void Start()
    {
        // score = 0;
        score = PlayerPrefs.GetInt("score");
    }


    private void OnTriggerEnter2D(Collider2D col) 
    {
        if (col.gameObject.tag == "Coin") 
        {
            score += 1; 
            Destroy (col.gameObject);
            highscore = (int)score; 
            scoreText.text = highscore.ToString(); 

             if(PlayerPrefs.GetInt("score") <= highscore)
            {
                PlayerPrefs.SetInt("score", highscore);
                highscoreFUn();
            }
           
        }
    }


    public void highscoreFUn()
    {
        scoreText.text = PlayerPrefs.GetInt("score").ToString(); 
    }















}
