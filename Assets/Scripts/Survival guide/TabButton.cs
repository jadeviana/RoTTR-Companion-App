using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TabButton : MonoBehaviour {
	[SerializeField] private Image ChevronUp;
	[SerializeField] private Image ChevronDown;
	[SerializeField] private GameObject SectionContent;
	
	private bool isExpanded;
	public void ToggleTab () {
		isExpanded = !isExpanded;

		if(isExpanded == true){
			ChevronUp.gameObject.SetActive(true);
			ChevronDown.gameObject.SetActive(false);
			SectionContent.gameObject.SetActive(true);
		}
		else {
			ChevronUp.gameObject.SetActive(false);
			ChevronDown.gameObject.SetActive(true);
			SectionContent.gameObject.SetActive(false);
		}
	}
}
