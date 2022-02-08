using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{


    [SerializeField]private string sceneName;

   IEnumerator DoChangeScene(string sceneName,float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(sceneName);
    }
    
    void OnTriggerEnter2D(Collider2D col)
    {
        if( col.tag == "Player")
        {
            Destroy(col.gameObject);
            StartCoroutine(DoChangeScene(sceneName,1f));

        }
    }
}
