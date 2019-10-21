using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WeaponManager : MonoBehaviour {

	//Screens
	private GameObject lastWeaponList;
	[SerializeField] private GameObject WeaponScreen;
	[SerializeField] private GameObject BowsList;
	[SerializeField] private GameObject HandgunsList;
	[SerializeField] private GameObject RiflesList;
	[SerializeField] private GameObject AxeList;

	[Space(18)]

	//Weapon Screen Elements
	[SerializeField] private Image weaponImage;
	[SerializeField] private TextMeshProUGUI barTitle;
	[SerializeField] private TextMeshProUGUI weaponTitle;
	[SerializeField] private TextMeshProUGUI description;

	[Space(18)]

	[SerializeField] private GameObject BowStats;
	public Slider BowDamageSlider;	
	public Slider DrawSpeedSlider;
	public Slider HoldTimeSlider;
	public Slider BowRateFireSlider;

	[Space(18)]

	[SerializeField] private GameObject GunStats;
	public Slider GunDamageSlider;	
	public Slider RecoilSlider;
	public Slider ReloadSlider;
	public Slider AmmoCapacitySlider;
	public Slider GunRateFireSlider;

	[Space(18)]

	[SerializeField] private TextMeshProUGUI firstAttachment;
	[SerializeField] private TextMeshProUGUI secondAttachment;
	[SerializeField] private TextMeshProUGUI thirdAttachment;


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

	public void OpenWeaponScreen(){
		lastWeaponList.gameObject.SetActive(false);
		WeaponScreen.gameObject.SetActive(true);
	}
}
