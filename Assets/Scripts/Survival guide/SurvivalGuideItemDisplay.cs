using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SurvivalGuideItemDisplay : MonoBehaviour {

	public SurvivalGuideItem listItem;
	[SerializeField] private TextMeshProUGUI guideItemTitle;

	public GuideManager manager;

	void Start () {
		guideItemTitle.text = listItem.ItemName;
	}

	public void SetPopUpContent(){
		manager.OpenPopUp(listItem.ItemName, listItem.description);
	}
}
