using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class SkillScreenDisplay : MonoBehaviour {
	public Skill ability;
	public Image skillIcon;
	public Image Lock;
	public TextMeshProUGUI barTitle;
	public TextMeshProUGUI skillTitle;
	public TextMeshProUGUI description;
	public TextMeshProUGUI requirement; 
	public TextMeshProUGUI cost;
	public TextMeshProUGUI skillPoint;
 
	private string reqDescription;


	// Use this for initialization
	void Start () {
		//Requirements
		if(ability.requirement == true){
			requirement.color = new Color32(123,6,27,255);
			Lock.gameObject.SetActive(true);
			reqDescription = ability.reqDescription;
		}
		else if(ability.requirement == false){
			reqDescription = "none";
		}

		//Top bar title
		if((int)ability.type == 1){
			barTitle.text = "brawler skill";
		} else if ((int)ability.type == 2){
			barTitle.text = "hunter skill";
		} else if ((int)ability.type == 3){
			barTitle.text = "survivor skill";
		}

		skillIcon.sprite = ability.skillIcon;
		skillTitle.text = ability.skillName;
		description.text = ability.skillDescription;
		requirement.text = reqDescription;

	}
}
