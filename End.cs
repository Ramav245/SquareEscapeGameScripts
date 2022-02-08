using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End : MonoBehaviour
{

    private ParticleSystem particle;

    private void Awake()
    {
        particle = GetComponentInChildren<ParticleSystem>();
    }


    private void OnCollisionEnter2D(Collision2D other)
    {
         if(other.collider.gameObject.tag == "Player")
         {
            StartCoroutine(Break());
            
         }
    }


    private IEnumerator Break()
    {
        particle.Play();

        yield return new WaitForSeconds(2f );
        Destroy(gameObject);
    }
















}
