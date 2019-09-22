using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum skillState {locked = 1, available = 2, upgraded = 3};
public enum skillType {brawler = 1, hunter = 2, survivor = 3};
public enum skillLevel {firstTier = 1, secondTier = 2, thirdTier = 3};

[CreateAssetMenu(fileName = "Skill", menuName = "Skill")]
public class Skill : ScriptableObject {
	public Sprite skillIcon;
	public string skillName;
	public string skillDescription;

	public skillState status;
	public skillType type;
	public skillLevel level;

	
	//Skills requirement
	public bool multiRequirement;
	public string requirementDescription1;
	public string requirementDescription2;
	public int skillCost = 1;
}
