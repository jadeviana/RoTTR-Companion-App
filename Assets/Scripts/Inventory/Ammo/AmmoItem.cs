using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ammoState{unavailable = 1, available = 2, full = 3};

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
	public ammoState status;

	public ResourceItem firstItem;
	public int firstItemCost;
	public ResourceItem secondItem;
	public int secondItemCost;
	public ResourceItem thirdItem = null;
	public int thirdItemCost;

	public void ammoStatus(){
		if(playerAmmoQnty == maxAmmo){
			status = ammoState.full;
		} else if (firstItem.playerQuantity < firstItemCost && secondItem.playerQuantity < secondItemCost){
			status = ammoState.unavailable;
		} else {
			status = ammoState.available;
		}
	}
}

