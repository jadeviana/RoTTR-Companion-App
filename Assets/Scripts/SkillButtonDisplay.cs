using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillButtonDisplay : MonoBehaviour {

		public Skill item;
		public Image Lock;
		public Image Check;
		public Image skillIcon;
		public Image background;
		public Image div;
		public Image lockedBar;

		private int buttonState;
	// Use this for initialization
	void Start () {

		skillIcon.sprite = item.skillIcon;
		buttonState = (int)item.status;
		
		//if the equipment state is locked, it should change the button's colour (red) and set the lock and lock bar image to active
		if(buttonState == 1){
			div.color = new Color32(123,6,27,255);
			background.color = new Color32(123,6,27,255);
			skillIcon.color = new Color32(123,6,27,255);
			Lock.gameObject.SetActive(true);
			lockedBar.gameObject.SetActive(true);
		}

		//if the equipment state is upgrade, it should change the button's colour (grey) and set the check image to active
		else if (buttonState == 3)
		{
			div.color = new Color32(101,101,101,255);
			background.color = new Color32(101,101,101,255);
			skillIcon.color = new Color32(101,101,101,255);
			Check.gameObject.SetActive(true);
		}
	}

}
