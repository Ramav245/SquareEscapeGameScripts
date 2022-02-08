using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
public class Coin : MonoBehaviour
{
     [SerializeField]private Text scoreText; 
    float score; 
    int highscore; 

    void Start()
    {
        score = 0;
    }

    private void OnTriggerEnter2D(Collider2D col) {
         if (col.gameObject.tag == "Player") {
             score += 1; 
             Destroy (gameObject);
             highscore = (int)score; 
            scoreText.text = highscore.ToString(); 
         }
     }
}
