using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SummaryItemDisplay : MonoBehaviour {
public SummaryItem item;
public Image smIcon;
public Image smRadial;
private float radialValue = 0;
public TextMeshProUGUI smTitle;
public TextMeshProUGUI smQuantity;

	// Use this for initialization
	void Start () {
		smIcon.sprite = item.summaryIcon;
		smTitle.text = item.summaryName;
		smQuantity.text = item.playerQty.ToString() + "/" + item.maximumQty.ToString();
		fillRadial();
	}
	
	void fillRadial(){
		radialValue = (float)item.playerQty / (float)item.maximumQty;
		smRadial.fillAmount = radialValue;
	}
}
