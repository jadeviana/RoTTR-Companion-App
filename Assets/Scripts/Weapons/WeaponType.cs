using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum textDisplay {found = 1, available = 2};

[CreateAssetMenu(fileName = "WeaponType", menuName = "Weapon Type")]
public class WeaponType : ScriptableObject {
	public Sprite weaponTypeIcon;
	public string weaponTypeName;
	public int weaponTypeFound;
	public int weaponTypeTotal;
	public textDisplay textDisplayed;
}
