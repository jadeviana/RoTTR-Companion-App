using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WeaponButton : MonoBehaviour {
	public Weapon weapon;
	public Image weaponIcon;
	public TextMeshProUGUI weaponTitle;
	public TextMeshProUGUI completion;

	public WeaponManager manager;


	// Use this for initialization
	void Start () {
		weaponIcon.sprite = weapon.weaponIcon;
		weaponTitle.text = weapon.weaponName;

		completion.text = ((weapon.weaponUpgrades*100)/weapon.upgradesTotal).ToString() + "% complete";
	}
	
	public void SetWeaponScreen(){
		manager.OpenWeaponScreen();
	}
}
