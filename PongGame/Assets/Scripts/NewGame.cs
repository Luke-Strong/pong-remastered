using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGame : MonoBehaviour
{

	void OnMouseDown ()
	{
		transform.localScale *= 0.9F;
	}

	void OnMouseUp ()

	{
		EnemyScore.enemyPoints = 0; 
		PlayerScore.turn = 0;
		PlayerScore.playerPoints = 0; 
		Time.timeScale = 1; //Unpause game (game was paused in the CheckWinner Function in Player/EnemyScore
		SceneManager.LoadScene (1);
	}
}
