using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "AmmoItem", menuName = "Inventory/AmmoItem")]
public class AmmoItem : ScriptableObject {
	public Sprite ammoIcon;
	public Sprite ammoImage;
	public string ammoName;
	public string ammoDescription;
	public bool hasRequirement;
	public string ammoRequirement;
	public int playerAmmoQnty;
	public int maxAmmo;

	public ResourceItem firstItem;
	public int firstItemCost;
	public ResourceItem secondItem;
	public int secondItemCost;
	public ResourceItem thirdItem = null;
	public int thirdItemCost;

}

