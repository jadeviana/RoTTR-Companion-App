using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Upgrade{
	public WeaponUpgrade upgrades;
}

//[CreateAssetMenu(fileName = "Weapon", menuName = "Weapon/Weapon Item")]
public class Weapon : ScriptableObject {

	[Header ("General Information")][Space(4)]
	public Sprite weaponIcon;
	public Sprite weaponImage;
	public string weaponName;
	public string weaponDescription;

	[Space(10)][Header ("Attachments")][Space(4)]
	public string attachmentDescription1;
	public string attachmentDescription2;
	public string attachmentDescription3;

	[Space(10)][Header ("Upgrades")][Space(4)]

	public List<Upgrade> upgradeTier1;
	public List<Upgrade> upgradeTier2;
	public List<Upgrade> upgradeTier3;
	public List<Upgrade> upgradeTier4;

}
