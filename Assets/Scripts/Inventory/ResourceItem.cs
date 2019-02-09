using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ResourceItem", menuName = "Inventory/ResourceItem", order = 0)]
public class ResourceItem : ScriptableObject {
	public Sprite resourceImage;
	public string resourceName;
	public int playerQuantity;
	public int maximumQuantity;
}