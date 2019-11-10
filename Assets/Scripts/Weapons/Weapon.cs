using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum weaponType {bow = 1, gun = 2, axe = 3};

[CreateAssetMenu(fileName = "Weapon", menuName = "Weapon/Weapon Item")]
public class Weapon : ScriptableObject {

	public weaponType weaponType;
	public Sprite weaponIcon;
	public Sprite weaponImage;

	public string weaponName;
	public string weaponDescription;

	public string attachmentDescription1;
	public string attachmentDescription2;
	public string attachmentDescription3;

	
	public int weaponUpgrades;
	public int upgradesTotal;


	//Weapon Stats


	//Weapon Upgrades
}
