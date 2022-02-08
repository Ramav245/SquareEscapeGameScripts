using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopControlScript : MonoBehaviour {

	int moneyAmount;
	int isRifleSold;

	public Text moneyAmountText;
	public Text riflePrice;

	public Button buyButton;

	// Use this for initialization
	void Start () {
		moneyAmount = PlayerPrefs.GetInt ("score");
	}
	
	// Update is called once per frame
	void Update () {
		
		moneyAmountText.text = moneyAmount.ToString() + "$";

		isRifleSold = PlayerPrefs.GetInt ("IsRifleSold");

		if (moneyAmount >= 5 && isRifleSold == 0)
			buyButton.interactable = true;
		else
			buyButton.interactable = false;	
	}

	public void buyRifle()
	{
		moneyAmount -= 5;
		PlayerPrefs.SetInt ("IsRifleSold", 1);
		riflePrice.text = "Sold!";
		buyButton.gameObject.SetActive (false);
	}


	public void buyRifle1()
	{
		moneyAmount -= 10;
		PlayerPrefs.SetInt ("IsRifleSold", 1);
		riflePrice.text = "Sold!";
		buyButton.gameObject.SetActive (false);
	}











	public void exitShop()
	{
		PlayerPrefs.SetInt ("score", moneyAmount);
		SceneManager.LoadScene ("level1");
	}

	public void resetPlayerPrefs()
	{
		moneyAmount = 0;
		buyButton.gameObject.SetActive (true);
		riflePrice.text = "Price: 5$";
		PlayerPrefs.DeleteAll ();
	}

}
