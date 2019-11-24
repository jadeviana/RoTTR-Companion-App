using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WeaponManager : MonoBehaviour {

	[Header ("Screens")]
	private GameObject lastWeaponList;
	[SerializeField] private GameObject WeaponScreen;
	[SerializeField] private GameObject BowsList;
	[SerializeField] private GameObject HandgunsList;
	[SerializeField] private GameObject RiflesList;
	[SerializeField] private GameObject AxeList;

	[Space(18)]

	[Header ("Image and Text Elements")]
	[SerializeField] private Image weaponImage;
	[SerializeField] private TextMeshProUGUI barTitle;
	[SerializeField] private TextMeshProUGUI weaponTitle;
	[SerializeField] private TextMeshProUGUI description;

	[Space(18)]

	[Header ("Bow Stat Sliders")]
	[SerializeField] private GameObject BowStats;
	public Slider BowDamageSlider;	
	public Slider DrawSpeedSlider;
	public Slider HoldTimeSlider;
	public Slider BowRateFireSlider;

	[Space(18)]

	[Header ("Gun Stat Sliders")]
	[SerializeField] private GameObject GunStats;
	public Slider GunDamageSlider;	
	public Slider RecoilSlider;
	public Slider ReloadSlider;
	public Slider AmmoCapacitySlider;
	public Slider GunRateFireSlider;

	[Space(18)]

	[Header ("Attachments")]
	[SerializeField] private TextMeshProUGUI firstAttachment;
	[SerializeField] private TextMeshProUGUI secondAttachment;
	[SerializeField] private TextMeshProUGUI thirdAttachment;

	[SerializeField] private TextMeshProUGUI UpgradeNumbers;

	void Update () {
		if (BowsList.activeSelf)
		{
			lastWeaponList = BowsList;
		}
		if (HandgunsList.activeSelf)
		{
			lastWeaponList = HandgunsList;
		}
		if (RiflesList.activeSelf)
		{
			lastWeaponList = RiflesList;
		}
		if (AxeList.activeSelf)
		{
			lastWeaponList = AxeList;
		}
	}

	public void ReturnLastScreen(){
		if (lastWeaponList != null){
			WeaponScreen.gameObject.SetActive(false);
			lastWeaponList.gameObject.SetActive(true);
		}
	}

	public void OpenWeaponScreen(Weapon selectedWeapon){
		barTitle.text = selectedWeapon.weaponName;
		weaponImage.sprite = selectedWeapon.weaponImage;
		weaponTitle.text = selectedWeapon.weaponName;
		description.text = selectedWeapon.weaponDescription;

		//Stats states
		switch((int)selectedWeapon.weaponType){
			case 1: //weapon is a bow
			BowStats.gameObject.SetActive(true);
			GunStats.gameObject.SetActive(false);
			break;

			case 2: //weapon is a gun
			BowStats.gameObject.SetActive(false);
			GunStats.gameObject.SetActive(true);
			break;

			case 3: //weapon is an axe
			BowStats.gameObject.SetActive(false);
			GunStats.gameObject.SetActive(false);
			break;
		}

		//Attachments
		if(selectedWeapon.attachmentDescription1 == "" && selectedWeapon.attachmentDescription2 == "" && selectedWeapon.attachmentDescription3 == ""){
			firstAttachment.text = "no attachments available";
			secondAttachment.text = "";
			thirdAttachment.text = "";
		} else{			
			firstAttachment.text = selectedWeapon.attachmentDescription1;
			secondAttachment.text = selectedWeapon.attachmentDescription2;
			thirdAttachment.text = selectedWeapon.attachmentDescription3;
		}


		UpgradeNumbers.text = selectedWeapon.weaponUpgrades + "/" + selectedWeapon.upgradesTotal;

		lastWeaponList.gameObject.SetActive(false);
		WeaponScreen.gameObject.SetActive(true);
	}
}
