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

	[SerializeField] private GameObject attachment1; 
	[SerializeField] private TextMeshProUGUI firstAttachmentName;
	[SerializeField] private GameObject attachment2; 
	[SerializeField] private TextMeshProUGUI secondAttachmentName;
	[SerializeField] private GameObject attachment3; 
	[SerializeField] private TextMeshProUGUI thirdAttachmentName;

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

	}
}
