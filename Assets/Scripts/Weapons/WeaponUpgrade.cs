using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum status {locked = 1, available = 2, unavailable = 3, upgraded = 4};
public class WeaponUpgrade : ScriptableObject {
	public string upgradeName;
	public Sprite upgradeIcon;
	public status upgradeStatus;
}
