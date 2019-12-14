using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Bow", menuName = "Weapon/Bow")]
public class Bow : Weapon {
	[Space(10)][Header ("Stats")][Space(4)]
	public int damage;
	public int drawSpeed;
	public int holdTime;
	public int rateOfFire;
}
