using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SkillManager : MonoBehaviour {

	//Player Skill points
	[SerializeField] private int playerSkillPoints;

	[Space(18)]

	//Screen objects
	[SerializeField] private GameObject SkillListObject;
	[SerializeField] private GameObject SkillDescriptionObject;

	[Space(18)] 

	//Skills List screen elements
	[SerializeField] private TextMeshProUGUI skillPointsAvailable;

	[Space(18)]

	//Skill Description screen elements
	[SerializeField] private Image skillIcon;
	[SerializeField] private Image Lock;
	[SerializeField] private TextMeshProUGUI barTitle;
	[SerializeField] private TextMeshProUGUI skillTitle;
	[SerializeField] private TextMeshProUGUI description;

	[Space(18)]
	[SerializeField] private GameObject Requirement1; 
	[SerializeField] private TextMeshProUGUI firstRequirementText; 
	[SerializeField] private GameObject Requirement2; 
	[SerializeField] private TextMeshProUGUI secondRequirementText;

	[Space(18)] 
	[SerializeField] private TextMeshProUGUI cost;
	[SerializeField] private TextMeshProUGUI skillPoint;
	[SerializeField] private Button upgradeBtn;
	[SerializeField] private TextMeshProUGUI upgradeBtnText;
 

	private void Start() {
		if (playerSkillPoints == 1)	{
		skillPointsAvailable.text = playerSkillPoints.ToString() + " skill point available";	
		} else {
		skillPointsAvailable.text = playerSkillPoints.ToString() + " skill points available";		
		}
	}

	public void OpenSkillScreen (Skill currentSkill) {
		SkillListObject.gameObject.SetActive(false);

		//Skill status and Requirements
		switch((int)currentSkill.status){

			case 1: // Skill is locked
				upgradeBtn.GetComponent<Button>().interactable = false;
				upgradeBtnText.color = new Color32(255,255,255,125);

				firstRequirementText.color = new Color32(123,6,27,255);

				Lock.color = new Color32(255,255,255,255);
				firstRequirementText.text = currentSkill.requirementDescription1;
			
				if(currentSkill.multiRequirement == true){
					Requirement2.gameObject.SetActive(true);
					secondRequirementText.text = currentSkill.requirementDescription2;
				}else{
					Requirement2.gameObject.SetActive(false);
				}
			break;

			case 2: // Skill is available
				firstRequirementText.text = "none";
				firstRequirementText.color = new Color32(255,255,255,255);
				Lock.color = new Color32(255,255,255,0);
				Requirement2.gameObject.SetActive(false);
				upgradeBtn.GetComponent<Button>().interactable = true;
				upgradeBtnText.color = new Color32(255,255,255,255);
			break;

			case 3: // Skill is mastered
				firstRequirementText.text = "mastered";
				firstRequirementText.color = new Color32(255,255,255,255);
				Lock.color = new Color32(255,255,255,0);
				Requirement2.gameObject.SetActive(false);
				upgradeBtn.GetComponent<Button>().interactable = false;
				upgradeBtnText.color = new Color32(255,255,255,125);
			break;

		}

		//Top bar title
		switch((int)currentSkill.type){

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

		skillIcon.sprite = currentSkill.skillIcon;
		skillTitle.text = currentSkill.skillName;
		description.text = currentSkill.skillDescription;

		if (playerSkillPoints == 1)	{
		skillPoint.text = playerSkillPoints.ToString() + " skill point";	
		} else {
		skillPoint.text = playerSkillPoints.ToString() + " skill points";		
		}

		SkillDescriptionObject.gameObject.SetActive(true);
	}
}
