using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public enum ammoState{unavailable = 1, available = 2, full = 3};
public class AmmoButtonDisplay : MonoBehaviour {
		public AmmoItem item;
		[SerializeField] private Image ammoIcon;
		[SerializeField] private Image buttonImage;

		[SerializeField] private TextMeshProUGUI ammoName;
		[SerializeField] private TextMeshProUGUI ammoQnty;
		[SerializeField] private GameObject Warning;
		[SerializeField] private GameObject Lock;

		public ammoState status;
		public AmmoManager manager;


	void Start () {
		ammoIcon.sprite = item.ammoIcon;
		ammoName.text = item.ammoName;
		ammoQnty.text = "your inventory: " + item.playerAmmoQnty + "/" + item.maxAmmo;

		ammoStatus();

		switch((int)status){

			case 1: //Ammo is unavailable to craft
				ammoQnty.color = new Color32(180,29,29,255);
				ammoName.color = new Color32(180,29,29,255);
				ammoIcon.color = new Color32(180,29,29,255);
				buttonImage.color = new Color32(180,29,29,255);

				Lock.gameObject.SetActive(true);
				Warning.gameObject.SetActive(false);		
			break;

			case 2: //Ammo is available
				ammoQnty.color = new Color32(255,255,255,255);
				ammoName.color = new Color32(255,255,255,255);
				ammoIcon.color = new Color32(255,255,255,255);
				buttonImage.color = new Color32(255,255,255,255);

				Lock.gameObject.SetActive(false);		
				Warning.gameObject.SetActive(false);
			break;

			case 3: //Ammo is full
				ammoQnty.color = new Color32(180,29,29,255);
				ammoName.color = new Color32(180,29,29,255);
				ammoIcon.color = new Color32(180,29,29,255);
				buttonImage.color = new Color32(180,29,29,255);

				Lock.gameObject.SetActive(false);
				Warning.gameObject.SetActive(true);
			break;

		}

	}

	public void ammoStatus(){

		if(item.playerAmmoQnty == item.maxAmmo){
			status = ammoState.full;
		}
		else if(item.hasRequirement == true){
			status = ammoState.unavailable;
		}
		else if(item.thirdItem != null){
			if (item.firstItem.playerQuantity < item.firstItemCost || item.secondItem.playerQuantity < item.secondItemCost || item.thirdItem.playerQuantity < item.thirdItemCost){
				status = ammoState.unavailable;
			} 
		} 
		else if (item.thirdItem = null){
			if (item.firstItem.playerQuantity < item.firstItemCost || item.secondItem.playerQuantity < item.secondItemCost){
				status = ammoState.unavailable;
			} 
		}

		else {
			status = ammoState.available;
		}

		//Debug.Log("ammo status for " +item.ammoName + " is " + status);
	}

	public void SetAmmoScreen(){
		manager.OpenAmmoScreen(item);
	}

}
