using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SummaryItem", menuName = "Lists/SummaryItem")]
public class SummaryItem : ScriptableObject {
	public Sprite summaryIcon;
	public string summaryName;
	public int playerQty;
	public int maximumQty;
}
