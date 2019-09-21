using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour {
	private GameObject lastScreen;
	[SerializeField] private GameObject MenuObject;
	[SerializeField] private GameObject BackgroundObject;

	[Space(18)]

	[SerializeField] private GameObject BaseCampObject;
	[SerializeField] private GameObject MarketplaceObject;
	[SerializeField] private GameObject LeaderboardObject;
	[SerializeField] private GameObject AchievementsObject;
	[SerializeField] private GameObject SurvivalGuideObject;

	
	void Update () {
		if (BaseCampObject.activeSelf)
		{
			lastScreen = BaseCampObject;
		}
		if (MarketplaceObject.activeSelf)
		{
			lastScreen = MarketplaceObject;
		}
		if (LeaderboardObject.activeSelf)
		{
			lastScreen = LeaderboardObject;
		}
		if (AchievementsObject.activeSelf)
		{
			lastScreen = AchievementsObject;
		}
		if (SurvivalGuideObject.activeSelf)
		{
			lastScreen = SurvivalGuideObject;
		}
	}

	public void CloseMenu(){
		if (lastScreen != null)
		{
		MenuObject.gameObject.SetActive(false);
		BackgroundObject.gameObject.SetActive(false);
		lastScreen.gameObject.SetActive(true);
		}
	}
}
