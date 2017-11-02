using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGame : MonoBehaviour
{
	public static int gameMode; 
	//0 = standard game;
	//1 = survival.

	void OnMouseDown ()
	{
		transform.localScale *= 0.9F;
	}

	void OnMouseUp ()

	{
		if (gameObject.tag == "Standard")
			gameMode = 0;
		else if (gameObject.tag == "Survival")
			gameMode = 1;
		
		EnemyScore.enemyPoints = 0; 
		PlayerScore.turn = 0;
		PlayerScore.playerPoints = 0; 
		PlayerScore.redBallHit = false;
		Time.timeScale = 1; //Unpause game (game was paused in the CheckWinner Function in Player/EnemyScore
		SceneManager.LoadScene (2);
	}
}
