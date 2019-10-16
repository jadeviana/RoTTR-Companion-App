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

	[SerializeField] private GameObject FirstStatObject;
	[SerializeField] private TextMeshProUGUI FirstStatTitle;
	public Slider FirstStatSlider;
	[SerializeField] private GameObject SecondStatObject;
	[SerializeField] private TextMeshProUGUI SecondStatTitle;
	public Slider SecondStatSlider;
	[SerializeField] private GameObject ThirdStatObject;
	[SerializeField] private TextMeshProUGUI ThirdStatTitle;
	public Slider ThirdStatSlider;
	[SerializeField] private GameObject FourthStatObject;
	[SerializeField] private TextMeshProUGUI FourthStatTitle;
	public Slider FourthStatSlider;
	[SerializeField] private GameObject FifthStatObject;
	[SerializeField] private TextMeshProUGUI FifthStatTitle;
	public Slider FifthStatSlider;

	[Space(18)]

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
