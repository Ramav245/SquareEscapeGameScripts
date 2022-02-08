using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Link : MonoBehaviour
{




    public string url;


    public void OpenIGURL()
    {
        Application.OpenURL("https://www.instagram.com/visiongaminggaming/");
    }

    public void OpenfbURL()
    {
        Application.OpenURL("https://www.facebook.com/Vision-Gaming-105432518443755");
    }




}
