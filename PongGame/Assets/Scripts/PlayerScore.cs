using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour {

	public TextMesh playerScore; 
	public TextMesh result; //Displays 'the player has won'
	public TextMesh returnMenu; //Returns player to menu scene.
	public TextMesh playAgain; //Restarts the game

	public GameObject ballPref; //Instanstiates Ball prefab again for respawn
	public GameObject greenBallPref;
	public GameObject redBallPref;

	public Transform paddleObj;

	GameObject ball;
	GameObject redBall;

	public static int turn = 0;

	public static int playerPoints = 0; 


	void Update () 
	{
		ball = GameObject.FindGameObjectWithTag ("Ball");
;

		playerScore.text = "" + playerPoints;
		checkWinner ();
	}

	void OnTriggerEnter (Collider other)
	{


		if (other.tag == "Ball") 
		{
			Destroy (ball);

			playerPoints += 3;
			turn += 1;


			(Instantiate (ballPref, new Vector3 (paddleObj.transform.position.x + 2, paddleObj.transform.position.y, 0), Quaternion.identity) as GameObject).transform.parent = paddleObj;

			int rand = Random.Range(0,1);

			for (int i = 0; i < Mathf.Floor(turn/5); i++)
				Instantiate (greenBallPref, new Vector3 (0, Random.Range (-12, 12), 0), Quaternion.identity);

			for (int i = 0; i < Mathf.Floor(turn/7); i++)
				Instantiate (redBallPref, new Vector3 (0, Random.Range (-12, 12), 0), Quaternion.identity);




		


		} 


	}

	void checkWinner()
	{
		if (NewGame.gameMode == 0) {
			if (playerPoints >= 50) {
				result.text = "YOU WIN!";
				returnMenu.text = "RETURN TO MENU";
				playAgain.text = "PLAY AGAIN";
				Time.timeScale = 0;

			}
				} else if (NewGame.gameMode == 1) {
					if (EnemyScore.enemyPoints - playerPoints > 20 || Input.GetKeyDown(KeyCode.Escape) ) //10 points to win
					{
						result.text = "YOU LOSE!";
						returnMenu.text = "RETURN TO MENU";
						playAgain.text = "PLAY AGAIN";
						Time.timeScale = 0;
				if (playerPoints > PlayerPrefs.GetInt ("High Score")) {
					PlayerPrefs.SetInt ("High Score", playerPoints);
				}					
			}
				
		}
			
	}




}
