using UnityEngine;
using System.Collections;

public class HUD : MonoBehaviour {
	//How many times the each game has been played, add counter to each different game startup
	public static int platformerTimesPlayed = 0;
	public static int spaceShooterTimesPlayed = 0;
	public static int pacmanTimesPlayed = 0;

	//total games played, every 5th game played awards bonus money to the player.
	public bool bonusActive=false;
	public static int currentGamesPlayed=0;
	public static int totalGamesPlayed=0;
	public static int totalGameViews=0;

	//Amount of money player will get each time.
	public int platformWorth = 5;
	public int spaceWorth = 10;
	public int pacmanWorth = 15;

	//Amount of money the player has and how many views.
	public int calculatingMoney = 0;
	public static int playerMoney = 50;
	public static int playerPageViews = 25;

	public static bool playedPlat = false;

	//These variables are set to the save file code, money and pageviews will be changed to these named variables after
	//all algorithms are calculated.
	//public int money = playerMoney;
	//public int pageviews = playerPageViews;
	void Start () 
	{
		
	}
	
	void Update () 
	{
		//Adds correct amount of money to the player depending on bonuses for the platformer game.
		if (platformerTimesPlayed>=1)
		{
			totalGamesPlayed++;
			currentGamesPlayed=currentGamesPlayed+1;
			playerPageViews = (playerPageViews + currentGamesPlayed)*2;
			//if player has played 5 games, money from playing the 5th game is doubled and then totalgames played is 
			//reset back to 0.
			if (totalGamesPlayed >=5)
			{
				bonusActive=true;
				totalGamesPlayed=0;
			}
			if (bonusActive=true)
			{
				calculatingMoney = platformWorth * 2;
				bonusActive=false;
			}
			if (bonusActive=false)
			{
				calculatingMoney = platformWorth;
			}
			playerMoney=playerMoney + calculatingMoney;
			calculatingMoney=0;
			platformerTimesPlayed=0;
			currentGamesPlayed=0;
		}

		//Adds correct amount of money to the player depending on bonuses for the space shooter game.
		if (spaceShooterTimesPlayed>=1)
		{
			totalGamesPlayed++;
			currentGamesPlayed=currentGamesPlayed+2;
			playerPageViews = (playerPageViews + currentGamesPlayed)*2;
			//if player has played 5 games, money from playing the 5th game is doubled and then totalgames played is 
			//reset back to 0.
			if (totalGamesPlayed >=5)
			{
				bonusActive=true;
				totalGamesPlayed=0;
			}
			if (bonusActive=true)
			{
				calculatingMoney = spaceWorth * 2;
				bonusActive=false;
			}
			if (bonusActive=false)
			{
				calculatingMoney = spaceWorth;
			}
			playerMoney=playerMoney + calculatingMoney;
			calculatingMoney=0;
			spaceShooterTimesPlayed=0;
			currentGamesPlayed=0;
		}

		//Adds correct amount of money to the player depending on bonuses for the pacman game.
		if (pacmanTimesPlayed>=1)
		{
			totalGamesPlayed++;
			currentGamesPlayed=currentGamesPlayed+3;
			playerPageViews = (playerPageViews + currentGamesPlayed)*2;
			//if player has played 5 games, money from playing the 5th game is doubled and then totalgames played is 
			//reset back to 0.
			if (totalGamesPlayed >=5)
			{
				bonusActive=true;
				totalGamesPlayed=0;
			}
			if (bonusActive==true)
			{
				calculatingMoney = pacmanWorth * 2;
				bonusActive=false;
			}
			if (bonusActive==false)
			{
				calculatingMoney = pacmanWorth;
			}
			playerMoney=playerMoney + calculatingMoney;
			calculatingMoney=0;
			pacmanTimesPlayed=0;
			currentGamesPlayed=0;
		}
	}
	//Dispal a label with player's money and page views.
	void OnGUI()
	{
		{
			GUI.Label(new Rect(0,0,Screen.width,Screen.height),"Money:" + playerMoney + "\nPageViws:" + playerPageViews);
		}
	}
}
