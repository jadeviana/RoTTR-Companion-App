using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum status {locked = 1, available = 2, unavailable = 3, upgraded = 4};

[CreateAssetMenu(fileName = "Weapon Upgrade", menuName = "Weapon/Weapon Upgrade")]
public class WeaponUpgrade : ScriptableObject {
	public Sprite upgradeIcon;
	public string upgradeName;
	public string upgradeDescription;
	public status upgradeStatus;
}
