using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

 
 public class AdsTimer: MonoBehaviour {
 
 public float timeLeft = 3.0f;
    public Text startText; // used for showing countdown from 3, 2, 1 
    [SerializeField]private string sceneName;
    private bool pressed = false;
    public GameObject ContinueButton;


    public void adsPressed()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("SavedScene"));
        pressed = true; 
        
    }

    void Awake() 
    {
        DontDestroyOnLoad(transform.gameObject);
    }

}
