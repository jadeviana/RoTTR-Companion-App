using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Gun", menuName = "Weapon/Gun")]
public class Gun : Weapon {
	[Space(10)][Header ("Stats")][Space(4)]
	public int damage;
	public int accuracy;
	public int reloadSpeed;
	public int ammoCapacity;
	public int rateOfFire;
}
