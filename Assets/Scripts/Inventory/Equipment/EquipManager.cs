using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EquipManager : MonoBehaviour {

	//Screens
	[SerializeField] private GameObject InventoryScreenObject;
	[SerializeField] private GameObject EquipScreenObject;

    [Space(18)] 

    //Equip Screen elements
	[SerializeField] private Image EquipImage;
	[SerializeField] private TextMeshProUGUI EquipName;
    [SerializeField] private TextMeshProUGUI EquipDescription;

	[Space(18)]

    [SerializeField] private GameObject firstRequirement;
    [SerializeField] private TextMeshProUGUI FirstRequirementText;
    [SerializeField] private GameObject SecondRequirement;
    [SerializeField] private TextMeshProUGUI SecondRequirementText;

	[Space(18)]

	[SerializeField] private GameObject firstItemCostObject;
	[SerializeField] private Image firstItem;
	[SerializeField] private TextMeshProUGUI firstItemCost;
	[SerializeField] private GameObject secondItemCostObject;
	[SerializeField] private Image secondItem;
	[SerializeField] private TextMeshProUGUI secondItemCost;
	[SerializeField] private GameObject thirdItemCostObject;
	[SerializeField] private Image thirdItem;
	[SerializeField] private TextMeshProUGUI thirdItemCost;
	
	[Space(18)]

	//Bottom bar
	[SerializeField] private GameObject firstItemInventoryObject;
	[SerializeField] private Image firstItemInventory;
	[SerializeField] private TextMeshProUGUI firstItemPQnty;
	[SerializeField] private GameObject secondItemInventoryObject;
	[SerializeField] private Image secondItemInventory;
	[SerializeField] private TextMeshProUGUI secondItemPQnty;
	[SerializeField] private GameObject thirdItemInventoryObject;
	[SerializeField] private Image thirdItemInventory;
	[SerializeField] private TextMeshProUGUI thirdItemPQnty;

	[Space(18)]

	[SerializeField] private Button UpgradeButton;
    [SerializeField] private TextMeshProUGUI UpgradeButtonText;

	public void OpenEquipScreen(EquipItem selectedEquip){
		InventoryScreenObject.gameObject.SetActive(false);

		EquipImage.sprite = selectedEquip.equipImage;
		EquipName.text = selectedEquip.equipName;
		EquipDescription.text = selectedEquip.equipDescription;

		//Requirements
		if (selectedEquip.firstRequirement == ""){
			firstRequirement.gameObject.SetActive(false);
		}
		else if(selectedEquip.firstRequirement != ""){
			firstRequirement.gameObject.SetActive(true);
			FirstRequirementText.text = selectedEquip.firstRequirement;
		}
		if (selectedEquip.secondRequirement == ""){
			SecondRequirement.gameObject.SetActive(false);
		} 
		else if(selectedEquip.secondRequirement != ""){
			SecondRequirement.gameObject.SetActive(true);
			SecondRequirementText.text = selectedEquip.secondRequirement;
		}

		//Costs and Inventory
		if(selectedEquip.firstItem == null && selectedEquip.secondItem == null){
			firstItemCostObject.gameObject.SetActive(false);
			secondItemCostObject.gameObject.SetActive(false);
			firstItemInventoryObject.gameObject.SetActive(false);
			secondItemInventoryObject.gameObject.SetActive(false);
		}
		else {
			firstItemCostObject.gameObject.SetActive(true);
			secondItemCostObject.gameObject.SetActive(true);
			firstItemInventoryObject.gameObject.SetActive(true);
			secondItemInventoryObject.gameObject.SetActive(true);


			firstItem.sprite = selectedEquip.firstItem.resourceImage;
			firstItemCost.text = selectedEquip.firstItemCost.ToString();
			firstItemInventory.sprite = selectedEquip.firstItem.resourceImage;
			firstItemPQnty.text = selectedEquip.firstItem.playerQuantity.ToString();

			secondItem.sprite = selectedEquip.secondItem.resourceImage;
			secondItemCost.text = selectedEquip.secondItemCost.ToString();
			secondItemInventory.sprite = selectedEquip.secondItem.resourceImage;
			secondItemPQnty.text = selectedEquip.secondItem.playerQuantity.ToString();

			if(selectedEquip.firstItemCost > selectedEquip.firstItem.playerQuantity){
				firstItemInventory.color = new Color32(123,6,27,255);
				firstItemPQnty.color = new Color32(123,6,27,255);
			} 
			else{
				firstItemInventory.color = new Color32(255,255,255,255);
				firstItemPQnty.color = new Color32(255,255,255,255);
			}
			if(selectedEquip.secondItemCost > selectedEquip.secondItem.playerQuantity){
				secondItemInventory.color = new Color32(123,6,27,255);
				secondItemPQnty.color = new Color32(123,6,27,255);
			}
			else{
				secondItemInventory.color = new Color32(255,255,255,255);
				secondItemPQnty.color = new Color32(255,255,255,255);
			}
		}

		if (selectedEquip.thirdItem != null){
			thirdItemCostObject.gameObject.SetActive(true);
			thirdItemInventoryObject.gameObject.SetActive(true);

			thirdItem.sprite = selectedEquip.thirdItem.resourceImage;
			thirdItemCost.text = selectedEquip.thirdItemCost.ToString();
			thirdItemInventory.sprite = selectedEquip.thirdItem.resourceImage;
			thirdItemPQnty.text = selectedEquip.thirdItem.playerQuantity.ToString();

			if(selectedEquip.thirdItemCost > selectedEquip.thirdItem.playerQuantity){
				thirdItemInventory.color = new Color32(123,6,27,255);
				thirdItemPQnty.color = new Color32(123,6,27,255);
			}
			else{
				thirdItemInventory.color = new Color32(255,255,255,255);
				thirdItemPQnty.color = new Color32(255,255,255,255);
			}
			
		} else{
			thirdItemCostObject.gameObject.SetActive(false);
			thirdItemInventoryObject.gameObject.SetActive(false);
		}

		//Craft Button
		if(selectedEquip.firstItem == null && selectedEquip.secondItem == null){
			UpgradeButton.GetComponent<Button>().interactable = false;
			UpgradeButtonText.color = new Color32(255,255,255,125);
		}
		else if(selectedEquip.thirdItem != null){
			if(selectedEquip.firstRequirement != ""){
				UpgradeButton.GetComponent<Button>().interactable = false;
				UpgradeButtonText.color = new Color32(255,255,255,125);
			}
			if(selectedEquip.firstItemCost > selectedEquip.firstItem.playerQuantity || selectedEquip.secondItemCost > selectedEquip.secondItem.playerQuantity || selectedEquip.thirdItemCost > selectedEquip.thirdItem.playerQuantity){
				UpgradeButton.GetComponent<Button>().interactable = false;
				UpgradeButtonText.color = new Color32(255,255,255,125);
			} 
			else {
				UpgradeButton.GetComponent<Button>().interactable = true;
				UpgradeButtonText.color = new Color32(255,255,255,255);
			}
		} 
		else{
			if(selectedEquip.firstRequirement != ""){
				UpgradeButton.GetComponent<Button>().interactable = false;
				UpgradeButtonText.color = new Color32(255,255,255,125);
			}
			if(selectedEquip.firstItemCost > selectedEquip.firstItem.playerQuantity || selectedEquip.secondItemCost > selectedEquip.secondItem.playerQuantity){
				UpgradeButton.GetComponent<Button>().interactable = false;
				UpgradeButtonText.color = new Color32(255,255,255,125);
			} 
			else {
				UpgradeButton.GetComponent<Button>().interactable = true;
				UpgradeButtonText.color = new Color32(255,255,255,255);
			}
		}

		EquipScreenObject.gameObject.SetActive(true);
	}

}
