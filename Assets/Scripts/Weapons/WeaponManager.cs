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

	[Space(18)][Header ("Image and Text Elements")]
	[SerializeField] private Image weaponImage;
	[SerializeField] private TextMeshProUGUI barTitle;
	[SerializeField] private TextMeshProUGUI weaponTitle;
	[SerializeField] private TextMeshProUGUI description;

	[Space(18)][Header ("Bow Stat Sliders")]
	[SerializeField] private GameObject BowStats;
	public Slider BowDamageSlider;	
	public Slider DrawSpeedSlider;
	public Slider HoldTimeSlider;
	public Slider BowRateFireSlider;

	[Space(18)][Header ("Gun Stat Sliders")]
	[SerializeField] private GameObject GunStats;
	public Slider GunDamageSlider;	
	public Slider RecoilSlider;
	public Slider ReloadSlider;
	public Slider AmmoCapacitySlider;
	public Slider GunRateFireSlider;

	[Space(18)][Header ("Attachments")]
	[SerializeField] private TextMeshProUGUI firstAttachment;
	[SerializeField] private TextMeshProUGUI secondAttachment;
	[SerializeField] private TextMeshProUGUI thirdAttachment;

	[Space(18)][Header ("Upgrades")]
	[SerializeField] private TextMeshProUGUI UpgradeNumbers;
	[SerializeField] private GameObject upgButton;
	[SerializeField] private Transform Upgrade1Tier;
	[SerializeField] private Transform Upgrade2Tier;
	[SerializeField] private Transform Upgrade3Tier;
	[SerializeField] private Transform Upgrade4Tier;

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
		if(selectedWeapon is Bow){
			BowStats.gameObject.SetActive(true);
			GunStats.gameObject.SetActive(false);
		}else if(selectedWeapon is Gun){
			BowStats.gameObject.SetActive(false);
			GunStats.gameObject.SetActive(true);
		}else if(selectedWeapon is Axe){
			BowStats.gameObject.SetActive(false);
			GunStats.gameObject.SetActive(false);
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
		// for(int i = 0; i < selectedWeapon.upg1Tier; i++){
		// 	Instantiate(upgButton,Upgrade1Tier).GetComponent<>();
		// }
		// for(int i = 0; i < selectedWeapon.upg2Tier; i++){

		// }
		// for(int i = 0; i < selectedWeapon.upg3Tier; i++){

		// }
		// for(int i = 0; i < selectedWeapon.upg4Tier; i++){

		// }

		lastWeaponList.gameObject.SetActive(false);
		WeaponScreen.gameObject.SetActive(true);
	}
}
