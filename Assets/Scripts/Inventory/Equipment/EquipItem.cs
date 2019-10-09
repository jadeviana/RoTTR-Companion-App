using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "EquipItem", menuName = "Inventory/EquipItem")]
public class EquipItem : ScriptableObject {
	public Sprite equipIcon;
	public Sprite equipImage;
	public string equipName;
	public string equipDescription;

	public string firstRequirement;
	public string secondRequirement;
	public bool isUpgraded;

	//Upgrade cost:
	public ResourceItem firstItem = null;
	public int firstItemCost;
	public ResourceItem secondItem = null;
	public int secondItemCost;
	public ResourceItem thirdItem = null;
	public int thirdItemCost;
}
