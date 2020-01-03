using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillButtonDisplay : MonoBehaviour {

		public Skill skill;
		[SerializeField] private Image Lock;
		[SerializeField] private Image Check;
		[SerializeField] private Image skillIcon;
		[SerializeField] private Image background;
		[SerializeField] private Image div;
		[SerializeField] private Image lockedBar;

		public SkillManager manager;

	// Use this for initialization
	void Start (){
		skillIcon.sprite = skill.skillIcon;
		switch(skill.status){
			case skillState.locked:			
				div.color = new Color32(123,6,27,255);
				background.color = new Color32(123,6,27,255);
				skillIcon.color = new Color32(123,6,27,255);
				Lock.gameObject.SetActive(true);
				lockedBar.gameObject.SetActive(true);
			break;

			case skillState.available:
				div.color = new Color32(255,255,255,255);
				background.color = new Color32(255,255,255,255);
				skillIcon.color = new Color32(255,255,255,255);
				Lock.gameObject.SetActive(false);
				lockedBar.gameObject.SetActive(false);
				Check.gameObject.SetActive(false);
			break;

			case skillState.upgraded:
				div.color = new Color32(101,101,101,255);
				background.color = new Color32(101,101,101,255);
				skillIcon.color = new Color32(101,101,101,255);
				Lock.gameObject.SetActive(false);
				lockedBar.gameObject.SetActive(false);
				Check.gameObject.SetActive(true);
			break;
		}
	}
	public void SetCardScreen(){
		manager.OpenSkillScreen(skill);
	}
}
