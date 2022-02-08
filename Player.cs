 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Player : MonoBehaviour
{

    public float moveSpeed; 
    private Vector3 targetPos; 
    Rigidbody2D rb; 
    


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        targetPos = transform.position; 
    }

    public void Move(Vector3 moveDirection)
    {
        targetPos += moveDirection;
        
    }


    void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);
    }


    
}


