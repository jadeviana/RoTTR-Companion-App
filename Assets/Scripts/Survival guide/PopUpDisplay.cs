using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PopUpDisplay : MonoBehaviour {

	public SurvivalGuideItem listItem;
	public TextMeshProUGUI itemTitle;
	public TextMeshProUGUI itemDescription;

	// Use this for initialization
	void Start () {
		itemTitle.text = listItem.ItemName;
		itemDescription.text = listItem.description;
	}

}
