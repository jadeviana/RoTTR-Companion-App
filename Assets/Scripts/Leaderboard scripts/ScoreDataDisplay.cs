using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreDataDisplay : MonoBehaviour {

	[SerializeField] private TextMeshProUGUI PlayerRank;
	[SerializeField] private TextMeshProUGUI PlayerName;
	[SerializeField] private TextMeshProUGUI PlayerPoints;
	public void Initialise (PlayerScore playerEntry) {
		//PlayerRank.text = playerEntry.PlayerName;
		PlayerName.text = playerEntry.PlayerName;
		PlayerPoints.text = playerEntry.score.ToString();
	}

}
