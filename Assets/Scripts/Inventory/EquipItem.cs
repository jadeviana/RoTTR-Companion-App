using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum equipState {locked = 1, available = 2, upgraded = 3};

[CreateAssetMenu(fileName = "EquipItem", menuName = "Inventory/EquipItem")]
public class EquipItem : ScriptableObject {
	public Sprite equipIcon;
	public Sprite equipImage;
	public string equipName;
	public string equipDescription;
	
	public equipState status;

	//Upgrade cost:
}
