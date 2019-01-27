using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldScoreList : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//World leaderboard list
		List<PlayerScore> Worldboard = new List<PlayerScore>();
		Worldboard.Add(new PlayerScore("Pr0to",10229));
		Worldboard.Add(new PlayerScore("jiro",9870));
		Worldboard.Add(new PlayerScore("blueShell",7871));
		Worldboard.Add(new PlayerScore("sage",9776));
		Worldboard.Add(new PlayerScore("c0olguy",7422));
		Worldboard.Add(new PlayerScore("Zeus",9845));
		Worldboard.Add(new PlayerScore("M O N S T E R",9963));
		Worldboard.Add(new PlayerScore("Trinity",10012));
		Worldboard.Add(new PlayerScore("KDyce",7927));
		Worldboard.Add(new PlayerScore("sparrow",8960));
		Worldboard.Add(new PlayerScore("H4rty",8201));
		Worldboard.Add(new PlayerScore("sKillo",9087));
		
		//World leaderboard sorting
		Worldboard.Sort();
		
	}
	
}
