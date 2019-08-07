using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SurvivalGuideItemDisplay : MonoBehaviour {

	public SurvivalGuideItem listItem;
	public TextMeshProUGUI guideItemTitle;

	// Use this for initialization
	void Start () {
		guideItemTitle.text = listItem.ItemName;
	}

}
