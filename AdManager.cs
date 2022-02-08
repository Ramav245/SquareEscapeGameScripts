using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements; 
using UnityEngine.UI; 


public class AdManager : MonoBehaviour
{
    string gameId = "4175209";
    bool testmode = false; 
    public GameObject AdsButton;
    public GameObject ContinueButton;

       void Start () {
        Advertisement.Initialize (gameId, testmode);
        ContinueButton.SetActive(false);
    }

        public void ShowInterstitialAd() {
        // Check if UnityAds ready before calling Show method:
        if (Advertisement.IsReady()) {
            Advertisement.Show();
            AdsButton.SetActive(false);
            ContinueButton.SetActive(true);

            
         // Replace mySurfacingId with the ID of the placements you wish to display as shown in your Unity Dashboard.
        } 
        else {
            Debug.Log("Interstitial ad not ready at the moment! Please try again later!");
        }
    }
}
