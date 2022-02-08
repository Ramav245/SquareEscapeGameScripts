﻿using System.Collections;
using UnityEngine;
using UnityEngine.Advertisements;

public class Banner : MonoBehaviour {

    public string gameId = "4204334";
    public string placementId = "Banner_iOS";
    public bool testMode = true;

    void Start () {
        // Initialize the SDK if you haven't already done so:
        Advertisement.Initialize (gameId, testMode);
        StartCoroutine (ShowBannerWhenReady ());
    }

    IEnumerator ShowBannerWhenReady () {
        while (!Advertisement.IsReady (placementId)) {
            yield return new WaitForSeconds (0.5f);
        }
        Advertisement.Banner.SetPosition (BannerPosition.TOP_CENTER);
        Advertisement.Banner.Show (placementId);
    }
}
