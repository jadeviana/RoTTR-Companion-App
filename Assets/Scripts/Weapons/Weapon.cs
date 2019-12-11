using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum weaponType {bow = 1, gun = 2, axe = 3};

[System.Serializable]
public class Stat{
	public string key = "";
	public int value = 0;
}

[System.Serializable]
public class Upgrade{
	public WeaponUpgrade upgrades;
}

[CreateAssetMenu(fileName = "Weapon", menuName = "Weapon/Weapon Item")]
public class Weapon : ScriptableObject {

	[Header ("General Information")][Space(4)]
	public weaponType weaponType;
	public Sprite weaponIcon;
	public Sprite weaponImage;

	public string weaponName;
	public string weaponDescription;

	[Space(10)][Header ("Attachments")][Space(4)]
	public string attachmentDescription1;
	public string attachmentDescription2;
	public string attachmentDescription3;

	
	[Space(10)][Header ("Stats")][Space(4)]
	public List<Stat> stats = new List<Stat>();


	[Space(10)][Header ("Upgrades")][Space(4)]
	public int weaponUpgrades;
	public int upgradesTotal;

	public List<Upgrade> upg1Tier = new List<Upgrade>();
	public List<Upgrade> upg2Tier = new List<Upgrade>();
	public List<Upgrade> upg3Tier = new List<Upgrade>();
	public List<Upgrade> upg4Tier = new List<Upgrade>();

}
