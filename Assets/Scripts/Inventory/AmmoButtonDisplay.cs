using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class AmmoButtonDisplay : MonoBehaviour {
		public AmmoItem item;
		public Image ammoIcon;
		public Image buttonImage;

		public TextMeshProUGUI ammoName;
		public TextMeshProUGUI ammoQnty;
		public GameObject Warning;
		public GameObject Lock;

		
	// Use this for initialization
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

		//If skill required is locked
		//else if (){
		//	ammoQnty.color = new Color32(180,29,29,255);
		//	ammoName.color = new Color32(180,29,29,255);
		//	ammoIcon.color = new Color32(180,29,29,255);
		//	buttonImage.color = new Color32(180,29,29,255);

		//	Lock.gameObject.SetActive(true);		
		//}
	}

}
