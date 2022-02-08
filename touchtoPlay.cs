using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class touchtoPlay : MonoBehaviour
{
    [SerializeField]private string sceneName;   
    void Update()
    {
        

        foreach (Touch touch in Input.touches) 
        {
            if((touch.position.y > Screen.height /3) && (touch.phase == TouchPhase.Began)) 
            {
                SceneManager.LoadScene(sceneName);
            }
        }   
    }
}
