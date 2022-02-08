using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

 
 public class Timer: MonoBehaviour {



    public float timeLeft = 3.0f;
    public Text startText; // used for showing countdown from 3, 2, 1 
    [SerializeField]private string sceneName;

    void Update()
    {


            timeLeft -= Time.deltaTime;
            startText.text = (timeLeft).ToString("0");

            if(timeLeft < 0)
            {
                //Do something useful or Load a new game scene depending on your use-case
                PlayerPrefs.SetInt("SavedScene", SceneManager.GetActiveScene().buildIndex);
                SceneManager.LoadScene(sceneName);
            }
    }
 }
 /*
    public float timeLeft = 3.0f;
    public Text startText; // used for showing countdown from 3, 2, 1 
    [SerializeField]private string sceneName;
    public bool timeStarted = true; 

    void Update()
    {

        if(timeStarted)
        {
            timeLeft -= Time.deltaTime;




            startText.text = (timeLeft).ToString("0");
            timeStarted = false; 

        }
        else if(timeStarted == false)
        {
            if (timeLeft < 0)
            {
                //load game over scene and pause game.
                PlayerPrefs.SetInt("SavedScene", SceneManager.GetActiveScene().buildIndex);
                SceneManager.LoadScene(sceneName);
        
            }
        
        }
    }



    void Awake() {
        DontDestroyOnLoad(transform.gameObject);
    }

}
*/