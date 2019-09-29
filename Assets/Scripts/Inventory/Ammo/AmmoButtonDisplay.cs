using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class AmmoButtonDisplay : MonoBehaviour {
		public AmmoItem item;
		[SerializeField] private Image ammoIcon;
		[SerializeField] private Image buttonImage;

		[SerializeField] private TextMeshProUGUI ammoName;
		[SerializeField] private TextMeshProUGUI ammoQnty;
		[SerializeField] private GameObject Warning;
		[SerializeField] private GameObject Lock;

		public AmmoManager manager;


	void Start () {
		ammoIcon.sprite = item.ammoIcon;
		ammoName.text = item.ammoName;
		ammoQnty.text = "your inventory: " + item.playerAmmoQnty + "/" + item.maxAmmo;

		//If inventory is full
		if(item.playerAmmoQnty == item.maxAmmo){
			ammoQnty.color = new Color32(180,29,29,255);
			ammoName.color = new Color32(180,29,29,255);
			ammoIcon.color = new Color32(180,29,29,255);
			buttonImage.color = new Color32(180,29,29,255);

			Warning.gameObject.SetActive(true);
		}

		//If not enough items to craft
		//else if (){
		//	ammoQnty.color = new Color32(180,29,29,255);
		//	ammoName.color = new Color32(180,29,29,255);
		//	ammoIcon.color = new Color32(180,29,29,255);
		//	buttonImage.color = new Color32(180,29,29,255);

		//	Lock.gameObject.SetActive(true);		
		//}
	}

	public void SetAmmoScreen(){
		
	}

}
