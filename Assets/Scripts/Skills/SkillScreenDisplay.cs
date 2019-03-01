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

	// Use this for initialization
	void Start () {
		skillIcon.sprite = ability.skillIcon;
		skillTitle.text = ability.skillName;
		description.text = ability.skillDescription;
		requirement.text = ability.requirement;
	}
}
