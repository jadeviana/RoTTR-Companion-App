using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MarketplaceManager : MonoBehaviour {

	//Screens
	[SerializeField] private GameObject MarketplaceScreenObject;
	[SerializeField] private GameObject CardScreenObject;
	[SerializeField] private GameObject AddOnScreenObject;

	//Card Screen elements
	[SerializeField] private Image CardScreenImage;
    [SerializeField] private TextMeshProUGUI CSTitle;
    [SerializeField] private TextMeshProUGUI CSDescription;
    [SerializeField] private TextMeshProUGUI CSValue;
    [SerializeField] private TextMeshProUGUI PopUpTitle;
    [SerializeField] private TextMeshProUGUI PopUpValue;
    [SerializeField] private TextMeshProUGUI PopUpPlayerCredit;

	//Add-on Screen elements
	[SerializeField] private Image AddOnScreenImage;
    [SerializeField] private TextMeshProUGUI AddOnTitle;
    [SerializeField] private TextMeshProUGUI AddOnDescription;
    [SerializeField] private TextMeshProUGUI AddOnValue;

	public void OpenCardScreen(Sprite cardImage, string cardTitle, string cardDescription, int cardValue){
		MarketplaceScreenObject.gameObject.SetActive(false);

        CardScreenImage.sprite = cardImage;
        CSTitle.text = cardTitle;
        CSDescription.text = cardDescription;
        CSValue.text = cardValue.ToString();

        PopUpTitle.text = cardTitle;
        PopUpValue.text = cardValue.ToString();

		CardScreenObject.gameObject.SetActive(true);
	}
	public void OpenAddOnScreen(Sprite AddOnImage, string AOTitle, string AODescription, float AOValue){
		MarketplaceScreenObject.gameObject.SetActive(false);

        AddOnScreenImage.sprite = AddOnImage;
        AddOnTitle.text = AOTitle;
        AddOnDescription.text = AODescription;
        AddOnValue.text = "$ " + AOValue.ToString();

		AddOnScreenObject.gameObject.SetActive(true);
	}

}
