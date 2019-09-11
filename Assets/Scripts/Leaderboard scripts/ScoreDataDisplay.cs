using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreDataDisplay : MonoBehaviour {

	[SerializeField] private TextMeshProUGUI PlayerRank;
	[SerializeField] private TextMeshProUGUI PlayerName;
	[SerializeField] private TextMeshProUGUI PlayerPoints;
	public void Initialise (PlayerScore playerEntry, int index) {
		PlayerRank.text = index.ToString();
		PlayerName.text = playerEntry.PlayerName;
		PlayerPoints.text = playerEntry.score.ToString();
	}

}
