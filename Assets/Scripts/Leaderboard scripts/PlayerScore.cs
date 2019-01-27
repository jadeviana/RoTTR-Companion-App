using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerScore : IComparable<PlayerScore> {


	public string PlayerName;
	public int score;

	public PlayerScore (string newName, int newScore){
		PlayerName = newName;
		score = newScore;
	}

	public int CompareTo(PlayerScore other){
		if(other == null){
			return 1;
		}
		return score = other.score;
	}
}
