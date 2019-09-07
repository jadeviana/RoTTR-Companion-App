using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {
		public List<PlayerScore> Worldboard = new List<PlayerScore>();
		public List<PlayerScore> Friendboard = new List<PlayerScore>();

		[SerializeField] private Transform worldBoardContent;
		[SerializeField] private Transform friendBoardContent;
		[SerializeField] private GameObject scoreboardEntryObject;

	// Use this for initialization
	void Start () {
		foreach (PlayerScore entry in Worldboard)
		{
			
		}

		foreach (PlayerScore entry in Friendboard)
		{
			
		}
		
	}
	
}
