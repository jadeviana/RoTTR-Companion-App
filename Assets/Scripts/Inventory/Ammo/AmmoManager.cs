using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AmmoManager : MonoBehaviour {

	//Screens
	[SerializeField] private GameObject InventoryScreenObject;
	[SerializeField] private GameObject AmmoScreenObject; 

    //Ammo Screen elements
	[SerializeField] private Image AmmoImage;
	[SerializeField] private Image AmmoIcon;
    [SerializeField] private TextMeshProUGUI AmmoName;
    [SerializeField] private TextMeshProUGUI AmmoDescription;
    [SerializeField] private TextMeshProUGUI AmmoQuantity;
    [SerializeField] private TextMeshProUGUI firstItemCost;
    [SerializeField] private TextMeshProUGUI firstItemQuantity;
    [SerializeField] private TextMeshProUGUI secondItemCost;
    [SerializeField] private TextMeshProUGUI secondItemQuantity;
    [SerializeField] private Button CraftButton;

	public void OpenAmmoScreen(AmmoItem selectedAmmo){

	}

}
