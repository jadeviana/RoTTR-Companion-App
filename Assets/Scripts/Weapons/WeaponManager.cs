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
	[SerializeField] private Transform Tier1Grid;
	[SerializeField] private Transform Tier2Grid;
	[SerializeField] private Transform Tier3Grid;
	[SerializeField] private Transform Tier4Grid;
	[SerializeField] private GameObject UpgradeButton;


	private int UpgradesTotal = 0;
	private int UpgradesDone;

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

			Bow chosenWeapon = (selectedWeapon as Bow);

			BowDamageSlider.value = (float)chosenWeapon.damage;
			DrawSpeedSlider.value = (float)chosenWeapon.drawSpeed;
			HoldTimeSlider.value = (float)chosenWeapon.holdTime;
			BowRateFireSlider.value = (float)chosenWeapon.rateOfFire;

		}else if(selectedWeapon is Gun){
			BowStats.gameObject.SetActive(false);
			GunStats.gameObject.SetActive(true);

			Gun chosenWeapon = (selectedWeapon as Gun);

			GunDamageSlider.value = (float)chosenWeapon.damage;
			RecoilSlider.value = (float)chosenWeapon.accuracy;
			ReloadSlider.value = (float)chosenWeapon.reloadSpeed;
			AmmoCapacitySlider.value = (float)chosenWeapon.ammoCapacity;
			GunRateFireSlider.value = (float)chosenWeapon.rateOfFire;

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

		//Upgrades
		UpgradesDone = 0;
		
		for (int i = 0; i < selectedWeapon.upgradeTier1.Count; i++){
			Instantiate(UpgradeButton,Tier1Grid);
			//UpgradeButton.GetComponent<weaponUpgradeDisplay>().SetUpgrades(selectedWeapon.upgradeTier1[i].upgrades);
			if(selectedWeapon.upgradeTier1[i].upgrades.upgradeStatus == status.locked){
				UpgradesDone++;
			}
		}
		for (int i = 0; i < selectedWeapon.upgradeTier2.Count; i++){
			Instantiate(UpgradeButton,Tier2Grid);
			if(selectedWeapon.upgradeTier2[i].upgrades.upgradeStatus == status.locked){
				UpgradesDone++;
			}
		}
		for (int i = 0; i < selectedWeapon.upgradeTier3.Count; i++){
			Instantiate(UpgradeButton,Tier3Grid);
			if(selectedWeapon.upgradeTier3[i].upgrades.upgradeStatus == status.locked){
				UpgradesDone++;
			}
		}
		for (int i = 0; i < selectedWeapon.upgradeTier4.Count; i++){
			Instantiate(UpgradeButton,Tier4Grid);
			if(selectedWeapon.upgradeTier4[i].upgrades.upgradeStatus == status.locked){
				UpgradesDone++;
			}
		}

		UpgradesTotal = selectedWeapon.upgradeTier1.Count + selectedWeapon.upgradeTier2.Count + selectedWeapon.upgradeTier3.Count + selectedWeapon.upgradeTier4.Count;
		UpgradeNumbers.text = UpgradesDone + "/" + UpgradesTotal;

		lastWeaponList.gameObject.SetActive(false);
		WeaponScreen.gameObject.SetActive(true);
	}

	public void DestroyUpgrades(){
        for(int i = Tier1Grid.transform.childCount -1; i <= 0; i--){
            GameObject.Destroy(Tier1Grid.transform.GetChild(i).gameObject);
        }
        for(int i = Tier2Grid.transform.childCount -1; i <= 0; i--){
            GameObject.Destroy(Tier2Grid.transform.GetChild(i).gameObject);
        }
        for(int i = Tier3Grid.transform.childCount -1; i <= 0; i--){
            GameObject.Destroy(Tier3Grid.transform.GetChild(i).gameObject);
        }
        for(int i = Tier4Grid.transform.childCount -1; i <= 0; i--){
            GameObject.Destroy(Tier4Grid.transform.GetChild(i).gameObject);
        }
	}
}
