using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WeaponTypeButton : MonoBehaviour {
	public WeaponType weaponType;
	public Image weaponIcon;
	public TextMeshProUGUI weaponTitle;
	public TextMeshProUGUI availability;

	void Start () {

		weaponIcon.sprite = weaponType.weaponTypeIcon;
		weaponTitle.text = weaponType.weaponTypeName;

		switch((int)weaponType.textDisplayed){
			case 1:
				availability.text = weaponType.weaponTypeFound.ToString() + "/" + weaponType.weaponTypeTotal.ToString() + " found";
			break;

			case 2:
				availability.text = weaponType.weaponTypeFound.ToString() + "/" + weaponType.weaponTypeTotal.ToString() + " available";
			break;
		}

		if(weaponType.weaponTypeFound == 0){
			GetComponent<Button>().interactable = false;
			weaponIcon.color = new Color32(255,255,255,125);
			weaponTitle.color = new Color32(255,255,255,125);
			availability.color = new Color32(255,255,255,125);
		}
	}

}
