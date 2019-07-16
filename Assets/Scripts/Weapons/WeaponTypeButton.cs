using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WeaponTypeButton : MonoBehaviour {
	public WeaponType weapon;
	public Image weaponIcon;
	public TextMeshProUGUI weaponTitle;
	public TextMeshProUGUI availability;

	void Start () {

		weaponIcon.sprite = weapon.weaponTypeIcon;
		weaponTitle.text = weapon.weaponTypeName;

		switch((int)weapon.textDisplayed){
			case 1:
				availability.text = weapon.weaponTypeFound.ToString() + "/" + weapon.weaponTypeTotal.ToString() + " found";
			break;

			case 2:
				availability.text = weapon.weaponTypeFound.ToString() + "/" + weapon.weaponTypeTotal.ToString() + " available";
			break;
		}

	}

}
