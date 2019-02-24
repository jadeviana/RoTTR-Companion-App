using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ammoState{locked = 1, available = 2, full = 3};

[CreateAssetMenu(fileName = "AmmoItem", menuName = "Inventory/AmmoItem")]
public class AmmoItem : ScriptableObject {
	public Sprite ammoIcon;
	public Sprite ammoImage;
	public string ammoName;
	public string ammoDescription;
	public int playerAmmoQnty;
	public int maxAmmo;
	public ammoState status;

	void ammoStatus(){
		//If item quantity is full
		if(playerAmmoQnty == maxAmmo){
			status = ammoState.full;
		}
		//If skill is locked
		//else if(){}
	}

	//craft cost:
}

