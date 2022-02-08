﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class purchaseButton : MonoBehaviour
{
    public enum PurchaseType {removeAds};
    public PurchaseType purchaseType;

    public void ClickPurchaseButton()
    {
        switch (purchaseType)
        {
            case PurchaseType.removeAds:
                IAPManager.instance.BuyRemoveAds();
                break; 
        }
    }
}
