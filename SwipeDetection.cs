﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeDetection : MonoBehaviour
{
    public Player player; 
    private Vector2 startPos; 
    public int pixelDistToDetect = 50;
    private bool fingerDown; 

    void Update()
    {
        if(fingerDown == false && Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            startPos = Input.touches[0].position; 
            fingerDown = true;
        }

        if(fingerDown)
        {
            if(Input.touches[0].position.y >= startPos.y + pixelDistToDetect)
            {
                fingerDown = false; 
                player.Move(Vector3.up);
            }
            else if(Input.touches[0].position.x <= startPos.x - pixelDistToDetect)
            {
                fingerDown = false; 
                player.Move(Vector3.left);

            }
            else if(Input.touches[0].position.x >= startPos.x + pixelDistToDetect)
            {
                fingerDown = false; 
                player.Move(Vector3.right);
            }
        }

        if(fingerDown && Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Ended )
        {
            fingerDown = false;
        }











    }





















}
