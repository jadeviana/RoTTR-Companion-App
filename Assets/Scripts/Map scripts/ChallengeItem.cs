using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ChallengeItem", menuName = "Lists/ChallengeItem")]
public class ChallengeItem : ScriptableObject {
	public string challengeTitle;
	public string challengeDescription;
	public int playerStat;
	public int maxStat;
}