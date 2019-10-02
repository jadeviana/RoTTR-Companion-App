using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AmmoManager : MonoBehaviour {

	//Screens
	[SerializeField] private GameObject InventoryScreenObject;
	[SerializeField] private GameObject AmmoScreenObject;

    [Space(18)] 

    //Ammo Screen elements
	[SerializeField] private Image AmmoImage;
	[SerializeField] private Image AmmoIcon;
    [SerializeField] private TextMeshProUGUI AmmoName;
    [SerializeField] private TextMeshProUGUI AmmoDescription;
    [SerializeField] private TextMeshProUGUI AmmoQuantity;

    [SerializeField] private Image firstItemImage;
    [SerializeField] private TextMeshProUGUI firstItemCost;
    [SerializeField] private TextMeshProUGUI firstItemQuantity;

    [SerializeField] private Image secondItemImage;
    [SerializeField] private TextMeshProUGUI secondItemCost;
    [SerializeField] private TextMeshProUGUI secondItemQuantity;
    [SerializeField] private Button CraftButton;

	public void OpenAmmoScreen(AmmoItem selectedAmmo){
        InventoryScreenObject.gameObject.SetActive(false);

        AmmoImage.sprite = selectedAmmo.ammoImage;
        AmmoName.text = selectedAmmo.ammoName;
        AmmoDescription.text  = selectedAmmo.ammoDescription;

        firstItemImage.sprite = selectedAmmo.firstItem.resourceImage;
        firstItemCost.text = selectedAmmo.firstItemCost.ToString();
        firstItemQuantity.text = selectedAmmo.firstItem.playerQuantity.ToString();

        secondItemImage.sprite = selectedAmmo.secondItem.resourceImage;
        secondItemCost.text = selectedAmmo.secondItemCost.ToString();
        secondItemQuantity.text = selectedAmmo.secondItem.playerQuantity.ToString();

        AmmoIcon.sprite = selectedAmmo.ammoIcon;
        AmmoQuantity.text = selectedAmmo.playerAmmoQnty + "/" + selectedAmmo.maxAmmo;

        AmmoScreenObject.gameObject.SetActive(true);
	}

}
