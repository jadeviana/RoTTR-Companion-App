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

	private int wUpgradesTotal;
	private int wUpgradesDone = 0;

	void Start () {
		weaponIcon.sprite = weapon.weaponIcon;
		weaponTitle.text = weapon.weaponName;

		for (int i = 0; i < weapon.upgradeTier1.Count; i++){
			if((int)weapon.upgradeTier1[i].upgrades.upgradeStatus == 4){
				wUpgradesDone++;
			}
		}
		for (int i = 0; i < weapon.upgradeTier2.Count; i++){
			if((int)weapon.upgradeTier2[i].upgrades.upgradeStatus == 4){
				wUpgradesDone++;
			}
		}
		for (int i = 0; i < weapon.upgradeTier3.Count; i++){
			if((int)weapon.upgradeTier3[i].upgrades.upgradeStatus == 4){
				wUpgradesDone++;
			}
		}
		for (int i = 0; i < weapon.upgradeTier4.Count; i++){
			if((int)weapon.upgradeTier4[i].upgrades.upgradeStatus == 4){
				wUpgradesDone++;
			}
		}

		wUpgradesTotal = weapon.upgradeTier1.Count + weapon.upgradeTier2.Count + weapon.upgradeTier3.Count + weapon.upgradeTier4.Count;
		completion.text = ((wUpgradesDone*100)/wUpgradesTotal).ToString() + "% complete";
	}
	
	public void SetWeaponScreen(){
		manager.OpenWeaponScreen(weapon);
	}
}
