﻿using System.Collections;
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
    [SerializeField] private TextMeshProUGUI AmmoRequirement;
    [SerializeField] private Image Lock;
    [SerializeField] private TextMeshProUGUI AmmoQuantity;

    [Space(18)]

    [SerializeField] private Image firstItemImage;
    [SerializeField] private TextMeshProUGUI firstItemCost;
    [SerializeField] private TextMeshProUGUI firstItemQuantity;

    [Space(18)]

    [SerializeField] private Image secondItemImage;
    [SerializeField] private TextMeshProUGUI secondItemCost;
    [SerializeField] private TextMeshProUGUI secondItemQuantity;

    [Space(18)]

    [SerializeField] private GameObject thirdItemCostDisplay;
    [SerializeField] private GameObject thirdItemQuantityDisplay;
    [SerializeField] private Image thirdItemImage;
    [SerializeField] private TextMeshProUGUI thirdItemCost;
    [SerializeField] private TextMeshProUGUI thirdItemQuantity;

    [Space(18)]

    [SerializeField] private Button CraftButton;

	public void OpenAmmoScreen(AmmoItem selectedAmmo){
        InventoryScreenObject.gameObject.SetActive(false);

        AmmoImage.sprite = selectedAmmo.ammoImage;
        AmmoName.text = selectedAmmo.ammoName;
        AmmoDescription.text  = selectedAmmo.ammoDescription;

        //If an ammo has a skill (or other) requirement or not
        if (selectedAmmo.hasRequirement == true){
            AmmoRequirement.text  = selectedAmmo.ammoRequirement;
            AmmoRequirement.color = new Color32(123,6,27,255);    
            Lock.color = new Color32(255,255,255,255);
        } else{
            AmmoRequirement.text  = "none";
            AmmoRequirement.color = new Color32(255,255,255,255);    
            Lock.color = new Color32(255,255,255,0);
        }

        firstItemImage.sprite = selectedAmmo.firstItem.resourceImage;
        firstItemCost.text = selectedAmmo.firstItemCost.ToString();
        firstItemQuantity.text = selectedAmmo.firstItem.playerQuantity.ToString();

        
        secondItemImage.sprite = selectedAmmo.secondItem.resourceImage;
        secondItemCost.text = selectedAmmo.secondItemCost.ToString();
        secondItemQuantity.text = selectedAmmo.secondItem.playerQuantity.ToString();

        //If an ammo requires or not a third item to craft
        if (selectedAmmo.thirdItem != null){
            thirdItemCostDisplay.gameObject.SetActive(true);
            thirdItemQuantityDisplay.gameObject.SetActive(true);

            thirdItemImage.sprite = selectedAmmo.thirdItem.resourceImage;
            thirdItemCost.text = selectedAmmo.thirdItemCost.ToString();
            thirdItemQuantity.text = selectedAmmo.thirdItem.playerQuantity.ToString();
        } else{
            thirdItemCostDisplay.gameObject.SetActive(false);
            thirdItemQuantityDisplay.gameObject.SetActive(false);
        }

        //If ammo cost is higher then player quantity
        if (selectedAmmo.thirdItem != null){

            if (selectedAmmo.firstItemCost > selectedAmmo.firstItem.playerQuantity){
                firstItemImage.color = new Color32(123,6,27,255);
                firstItemCost.color = new Color32(123,6,27,255);
            }
            if (selectedAmmo.secondItemCost > selectedAmmo.secondItem.playerQuantity){
                secondItemImage.color = new Color32(123,6,27,255);
                secondItemCost.color = new Color32(123,6,27,255);
            }
            if (selectedAmmo.thirdItemCost > selectedAmmo.thirdItem.playerQuantity){
                thirdItemImage.color = new Color32(123,6,27,255);
                thirdItemCost.color = new Color32(123,6,27,255);
            } else{
                firstItemImage.color = new Color32(255,255,255,255);
                firstItemCost.color = new Color32(255,255,255,255);

                secondItemImage.color = new Color32(255,255,255,255);
                secondItemCost.color = new Color32(255,255,255,255);

                thirdItemImage.color = new Color32(255,255,255,255);
                thirdItemCost.color = new Color32(255,255,255,255);
            }

        } else{

            if (selectedAmmo.firstItemCost > selectedAmmo.firstItem.playerQuantity){
                firstItemImage.color = new Color32(123,6,27,255);
                firstItemCost.color = new Color32(123,6,27,255);
            }
            if (selectedAmmo.secondItemCost > selectedAmmo.secondItem.playerQuantity){
                secondItemImage.color = new Color32(123,6,27,255);
                secondItemCost.color = new Color32(123,6,27,255);
            }else{
                firstItemImage.color = new Color32(255,255,255,255);
                firstItemCost.color = new Color32(255,255,255,255);

                secondItemImage.color = new Color32(255,255,255,255);
                secondItemCost.color = new Color32(255,255,255,255);
            }

        }

        AmmoIcon.sprite = selectedAmmo.ammoIcon;
        AmmoQuantity.text = selectedAmmo.playerAmmoQnty + "/" + selectedAmmo.maxAmmo;

        //Craft button interactable or not
        if(selectedAmmo.thirdItem != null){
            if (selectedAmmo.hasRequirement == false && selectedAmmo.firstItem.playerQuantity > selectedAmmo.firstItemCost && selectedAmmo.secondItem.playerQuantity > selectedAmmo.secondItemCost && selectedAmmo.thirdItem.playerQuantity > selectedAmmo.thirdItemCost){
                CraftButton.GetComponent<Button>().interactable = true;
                CraftButton.GetComponentInChildren<TextMeshProUGUI>().color = new Color32(255,255,255,255);
            }
        } 
        else if (selectedAmmo.thirdItem = null){
            if (selectedAmmo.hasRequirement == false && selectedAmmo.firstItem.playerQuantity > selectedAmmo.firstItemCost && selectedAmmo.secondItem.playerQuantity > selectedAmmo.secondItemCost){
                CraftButton.GetComponent<Button>().interactable = true;
                CraftButton.GetComponentInChildren<TextMeshProUGUI>().color = new Color32(255,255,255,255);
            }
        }
        else {
            CraftButton.GetComponent<Button>().interactable = false;
            CraftButton.GetComponentInChildren<TextMeshProUGUI>().color = new Color32(255,255,255,125);
        }

        AmmoScreenObject.gameObject.SetActive(true);
	}

}
