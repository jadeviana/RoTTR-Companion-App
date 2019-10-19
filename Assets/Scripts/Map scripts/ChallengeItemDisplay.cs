using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChallengeItemDisplay : MonoBehaviour {
	public ChallengeItem item;
	public TextMeshProUGUI cTitle;
    public TextMeshProUGUI cDescription;
	public Slider progress;
	public Image strikethrough;
	public Image arrow;
	public Image sliderFill;
	public TextMeshProUGUI stats;
	private float isComplete = 0;

	// Use this for initialization
	void Start () {
        cTitle.text = item.challengeTitle;
		cDescription.text = item.challengeDescription;
		stats.text = item.playerStat.ToString() + "/" + item.maxStat.ToString();
		progress.value = (float)item.playerStat / (float)item.maxStat;
		challengeStatus();
	}
	void challengeStatus(){
		isComplete = (float)item.playerStat / (float)item.maxStat;
		if(isComplete == 1){
			strikethrough.gameObject.SetActive(true);
			arrow.color = new Color32(255,255,255,125);
			cTitle.color = new Color32(255,255,255,125);
			cDescription.color = new Color32(255,255,255,125);
			stats.color = new Color32(255,255,255,125);
			sliderFill.color = new Color32(255,255,255,125);
		}
	}
}
