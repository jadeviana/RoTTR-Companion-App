using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {
	public List<PlayerScore> Worldboard = new List<PlayerScore>();
	public List<PlayerScore> Friendboard = new List<PlayerScore>();

	[SerializeField] private Transform worldBoardContent;
	[SerializeField] private Transform friendBoardContent;

	[SerializeField] private GameObject scoreboardEntryObject;
	[SerializeField] private GameObject worldBoardObject;
	[SerializeField] private GameObject friendBoardObject;

	[SerializeField] private Toggle worldBoardToggle;
	[SerializeField] private Toggle friendBoardToggle;


	private void WorldEntries(){
		Worldboard.Add(new PlayerScore(){PlayerName = "ColorfulPixie", score = 436308});
		Worldboard.Add(new PlayerScore(){PlayerName = "Wizart", score = 706360});
		Worldboard.Add(new PlayerScore(){PlayerName = "WhitePhantasm", score = 801373});
		Worldboard.Add(new PlayerScore(){PlayerName = "RadioactiveSpook", score = 973943});
		Worldboard.Add(new PlayerScore(){PlayerName = "BubbleTrooper", score = 281185});
		Worldboard.Add(new PlayerScore(){PlayerName = "BlandMermaid", score = 236664});
		Worldboard.Add(new PlayerScore(){PlayerName = "Coyotea", score = 487036});
		Worldboard.Add(new PlayerScore(){PlayerName = "ShinyLlama", score = 716024});
		Worldboard.Add(new PlayerScore(){PlayerName = "PlushPumpkin", score = 271229});
		Worldboard.Add(new PlayerScore(){PlayerName = "StylishElf", score = 983685});
		Worldboard.Add(new PlayerScore(){PlayerName = "Wrathhog", score = 211272});
		Worldboard.Add(new PlayerScore(){PlayerName = "KeyboardWizard", score = 950188});
		Worldboard.Add(new PlayerScore(){PlayerName = "Raptortilla", score = 322168});

		Worldboard.Sort((a, b) => b.score.CompareTo(a.score));

		for (int i = 0; i < Worldboard.Count; i++){
			var scoreIndex = Worldboard[i];
			Instantiate(scoreboardEntryObject,worldBoardContent).GetComponent<ScoreDataDisplay>().Initialise(scoreIndex, i+1);
		}
	}
	private void FriendEntries(){
		Friendboard.Add(new PlayerScore(){PlayerName = "UpsetAvocado", score =  8392});
		Friendboard.Add(new PlayerScore(){PlayerName = "IronOrc", score = 6897});
		Friendboard.Add(new PlayerScore(){PlayerName = "MadDuck", score = 9119});
		Friendboard.Add(new PlayerScore(){PlayerName = "FilthyAlpaca", score = 7649});
		Friendboard.Add(new PlayerScore(){PlayerName = "Titank", score = 6775});
		Friendboard.Add(new PlayerScore(){PlayerName = "ImpulseKoala", score = 3431});
		Friendboard.Add(new PlayerScore(){PlayerName = "FluffyDefender", score = 3645});
		Friendboard.Add(new PlayerScore(){PlayerName = "MidnightCrusader", score = 2606});

		Friendboard.Sort((a, b) => b.score.CompareTo(a.score));

		for (int i = 0; i < Friendboard.Count; i++){
			var scoreIndex = Friendboard[i];
			Instantiate(scoreboardEntryObject,friendBoardContent).GetComponent<ScoreDataDisplay>().Initialise(scoreIndex, i+1);
		}
	}

	private void Start () {
		WorldEntries();
		FriendEntries();
	}

	private void Update() {
		if (worldBoardToggle.isOn == true){
			worldBoardObject.gameObject.SetActive(true);
			friendBoardObject.gameObject.SetActive(false);
		}
		else if (friendBoardToggle.isOn == true){
			worldBoardObject.gameObject.SetActive(false);
			friendBoardObject.gameObject.SetActive(true);
		}
	}
	
}
