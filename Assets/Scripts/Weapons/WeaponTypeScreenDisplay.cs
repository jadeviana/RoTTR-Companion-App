using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WeaponTypeScreenDisplay : MonoBehaviour {

	public WeaponType weapon;
	public TextMeshProUGUI barTitle;
	public TextMeshProUGUI weaponAvailability;

	// Use this for initialization
	void Start () {

		barTitle.text = weapon.weaponTypeName;
		
		switch((int)weapon.textDisplayed){
			case 1:
				weaponAvailability.text = weapon.weaponTypeFound.ToString() + "/" + weapon.weaponTypeTotal.ToString() + " found";
			break;

			case 2:
				weaponAvailability.text = weapon.weaponTypeFound.ToString() + "/" + weapon.weaponTypeTotal.ToString() + " available";
			break;
		}
	}

}
