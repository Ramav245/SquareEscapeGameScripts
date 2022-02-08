using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;








public class sceneChange : MonoBehaviour
{

  
    [SerializeField]private string sceneName;

    public int levelToReach = 2; 




    public void OnTriggerEnter2D(Collider2D collision)
    {

        if(collision.gameObject.tag == "Player")
        {
            StartCoroutine(DoChangeScene(sceneName,1f));
            WinLevel(); 

        }
    }


    public void WinLevel()
    {
        PlayerPrefs.SetInt("levelReached", levelToReach);
    }
    
    IEnumerator DoChangeScene(string sceneName,float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(sceneName);
    }

}
