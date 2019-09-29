using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MarketplaceManager : MonoBehaviour {
    //Marketplace elements
    public int PlayerCredits;
    [SerializeField] private TextMeshProUGUI Credits;

    [Space(18)] 

	//Screens
	[SerializeField] private GameObject MarketplaceScreenObject;
	[SerializeField] private GameObject CardScreenObject;
	[SerializeField] private GameObject AddOnScreenObject;

    [Space(18)] 

    //Card Screen elements
    [SerializeField] private Image CardScreenImage;
    [SerializeField] private TextMeshProUGUI CardScreenTitle;
    [SerializeField] private TextMeshProUGUI CardScreenDescription;
    [SerializeField] private TextMeshProUGUI CardScreenValue;

    [Space(18)]

    //Card Pop-up elements
    [SerializeField] private TextMeshProUGUI PopUpTitle;
    [SerializeField] private TextMeshProUGUI PopUpValue;
    [SerializeField] private TextMeshProUGUI PopUpPlayerCredit;

    [Space(18)]

	//Add-on Screen elements
	[SerializeField] private Image AddOnScreenImage;
    [SerializeField] private TextMeshProUGUI AddOnTitle;
    [SerializeField] private TextMeshProUGUI AddOnDescription;
    [SerializeField] private TextMeshProUGUI AddOnValue;

    private void Start() {
        Credits.text = "Credits: " + PlayerCredits.ToString();
    }

    //Card Screen methods
	public void OpenCardScreen(MKTCard selectedCard){
		MarketplaceScreenObject.gameObject.SetActive(false);

        CardScreenImage.sprite = selectedCard.cardImage;
        CardScreenTitle.text = selectedCard.cardName;
        CardScreenDescription.text = selectedCard.description;
        CardScreenValue.text = selectedCard.credit.ToString();

        PopUpTitle.text = selectedCard.cardName;
        PopUpValue.text = selectedCard.credit.ToString();
        PopUpPlayerCredit.text = PlayerCredits.ToString();

		CardScreenObject.gameObject.SetActive(true);
	}

    //Add-On Screen methods
	public void OpenAddOnScreen(MKTAddOn selectedAddOn){
		MarketplaceScreenObject.gameObject.SetActive(false);

        AddOnScreenImage.sprite = selectedAddOn.addOnImage;
        AddOnTitle.text = selectedAddOn.addOnName;
        AddOnDescription.text = selectedAddOn.description;
        AddOnValue.text = "$ " + selectedAddOn.price.ToString();

		AddOnScreenObject.gameObject.SetActive(true);
	}

}
