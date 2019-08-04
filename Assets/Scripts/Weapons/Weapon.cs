using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Weapon", menuName = "Weapon/Weapon Item")]
public class Weapon : ScriptableObject {

	public Sprite weaponIcon;
	public Sprite weaponImage;

	public string weaponName;
	public string weaponDescription;

	public bool attachmentsAvailable;
	public string attachmentDescription;
	
	public int weaponUpgrades;
	public int upgradesTotal;


	//Weapon Stats

	//Weapon Upgrades
}
