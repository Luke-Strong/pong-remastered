using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ToMenu : MonoBehaviour {

	void OnMouseDown ()
	{
		transform.localScale *= 0.9F;
	}

	void OnMouseUp ()

	{
		Time.timeScale = 1; //Unpause game (game was paused in the CheckWinner Function in Player/EnemyScore
		SceneManager.LoadScene (0);
	}
}
