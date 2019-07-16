using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SkillScreenDisplay : MonoBehaviour {
	public Skill ability;
	public Image skillIcon;
	public Image Lock;
	public Image Lock2;
	public TextMeshProUGUI barTitle;
	public TextMeshProUGUI skillTitle;
	public TextMeshProUGUI description;
	public TextMeshProUGUI requirement; 
	public TextMeshProUGUI cost;
	public TextMeshProUGUI skillPoint;


	public Button upgradeBtn;
	public TextMeshProUGUI upgradeBtnText;
 
	private string reqDescription;

	void Start () {

		//Skill status and Requirements
		switch((int)ability.status){

			case 1: // Skill is locked
				upgradeBtn.GetComponent<Button>().interactable = false;
				upgradeBtnText.color = new Color32(255,255,255,125);

				requirement.color = new Color32(123,6,27,255);
				Lock.gameObject.SetActive(true);
				reqDescription = ability.requirementDescription;
			
				if(ability.multiRequirement == true){
					Lock2.gameObject.SetActive(true);
				}
			break;

			case 2: // Skill is available
				reqDescription = "none";
			break;

			case 3: // Skill is mastered
				reqDescription = "mastered";
				upgradeBtn.GetComponent<Button>().interactable = false;
				upgradeBtnText.color = new Color32(255,255,255,125);
			break;

		}

		//Top bar title
		switch((int)ability.type){

			case 1:
				barTitle.text = "brawler skill";
			break;

			case 2:
				barTitle.text = "hunter skill";
			break;

			case 3:
				barTitle.text = "survivor skill";
			break;

		}

		skillIcon.sprite = ability.skillIcon;
		skillTitle.text = ability.skillName;
		description.text = ability.skillDescription;
		requirement.text = reqDescription;

	}
}
