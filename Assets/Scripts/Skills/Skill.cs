using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum skillState {locked = 1, available = 2, upgraded = 3};
[CreateAssetMenu(fileName = "Skill", menuName = "Skill")]
public class Skill : ScriptableObject {
	public Sprite skillIcon;
	public string skillName;
	public string skillDescription;
	public int skillCost = 1;

	//Skills requirement
	public string requirement;
	public skillState status;

}
