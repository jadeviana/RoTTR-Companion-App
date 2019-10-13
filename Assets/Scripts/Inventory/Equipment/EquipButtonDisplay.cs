using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum equipState {locked = 1, unavailable = 2, available = 3, upgraded = 4};
public class EquipButtonDisplay : MonoBehaviour {

		public EquipItem item;
		[SerializeField] private Image Lock;
		[SerializeField] private Image Check;
		[SerializeField] private Image equipIcon;
		[SerializeField] private Image background;
		[SerializeField] private Image div;
		[SerializeField] private Image lockedBar;

		private equipState status;

		public EquipManager manager;


	// Use this for initialization
	void Start () {
		SetEquipStatus();
		equipIcon.sprite = item.equipIcon;
		
		switch((int)status){

			case 1: //Equipment is locked
				div.color = new Color32(123,6,27,255);
				background.color = new Color32(123,6,27,255);
				equipIcon.color = new Color32(123,6,27,255);

				Lock.gameObject.SetActive(true);
				lockedBar.gameObject.SetActive(true);
				Check.gameObject.SetActive(false);
			break;

			case 2: //Equipment is unavailable
				div.color = new Color32(123,6,27,255);
				background.color = new Color32(123,6,27,255);
				equipIcon.color = new Color32(123,6,27,255);

				Lock.gameObject.SetActive(false);
				lockedBar.gameObject.SetActive(false);
				Check.gameObject.SetActive(false);
			break;

			case 3: //Equipment is available
				div.color = new Color32(255,255,255,255);
				background.color = new Color32(255,255,255,255);
				equipIcon.color = new Color32(255,255,255,255);

				Lock.gameObject.SetActive(false);
				lockedBar.gameObject.SetActive(false);
				Check.gameObject.SetActive(false);
			break;

			case 4: //Equipment is upgraded
				div.color = new Color32(101,101,101,255);
				background.color = new Color32(101,101,101,255);
				equipIcon.color = new Color32(101,101,101,255);

				Lock.gameObject.SetActive(false);
				lockedBar.gameObject.SetActive(false);
				Check.gameObject.SetActive(true);
			break;

		}

	}
	
	void SetEquipStatus(){
		if (item.firstRequirement != "" || item.secondRequirement != ""){
			status = equipState.locked;
		}
		else if (item.isUpgraded == true){
			status = equipState.upgraded;
		}
		else if(item.thirdItem == null){
			if (item.firstItemCost < item.firstItem.playerQuantity && item.secondItemCost < item.secondItem.playerQuantity){
				status = equipState.available;
			} 
			else{
				status = equipState.unavailable;
			}		
		}
		else if(item.thirdItem != null){
			if (item.firstItemCost < item.firstItem.playerQuantity && item.secondItemCost < item.secondItem.playerQuantity && item.thirdItemCost < item.thirdItem.playerQuantity){
				status = equipState.available;
			} 
			else{
				status = equipState.unavailable;
			}		
		} 
	}

	public void SetEquipScreen(){
		manager.OpenEquipScreen(item);
	}
}
