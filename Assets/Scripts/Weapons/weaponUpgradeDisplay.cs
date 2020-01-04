using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class weaponUpgradeDisplay : MonoBehaviour {
	[SerializeField] private Image Lock;
	[SerializeField] private Image Check;
	[SerializeField] private Image upgradeIcon;
	[SerializeField] private Image background;
	[SerializeField] private Image div;
	[SerializeField] private Image lockedBar;

	public void SetUpgrades (WeaponUpgrade currentUpgrade) {
		//Debug.Log(currentUpgrade.upgradeName + " is " + currentUpgrade.upgradeStatus);
		upgradeIcon.sprite = currentUpgrade.upgradeIcon;
		switch(currentUpgrade.upgradeStatus){
			case status.locked:
				div.color = new Color32(123,6,27,255);
				background.color = new Color32(123,6,27,255);
				upgradeIcon.color = new Color32(123,6,27,255);
				Lock.gameObject.SetActive(true);
				lockedBar.gameObject.SetActive(true);
				Check.gameObject.SetActive(false);
			break;

			case status.available:
				div.color = new Color32(255,255,255,255);
				background.color = new Color32(255,255,255,255);
				upgradeIcon.color = new Color32(255,255,255,255);
				Lock.gameObject.SetActive(false);
				lockedBar.gameObject.SetActive(false);
				Check.gameObject.SetActive(false);
			break;

			case status.unavailable:
				div.color = new Color32(123,6,27,255);
				background.color = new Color32(123,6,27,255);
				upgradeIcon.color = new Color32(123,6,27,255);
				Lock.gameObject.SetActive(false);
				lockedBar.gameObject.SetActive(false);
				Check.gameObject.SetActive(false);
			break;

			case status.upgraded:
				div.color = new Color32(101,101,101,255);
				background.color = new Color32(101,101,101,255);
				upgradeIcon.color = new Color32(101,101,101,255);
				Lock.gameObject.SetActive(false);
				lockedBar.gameObject.SetActive(false);
				Check.gameObject.SetActive(true);
			break;
		}
	}
}
