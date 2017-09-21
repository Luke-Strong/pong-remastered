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

	}

	void OnTriggerEnter (Collider other)
	{


		if (other.tag == "Ball") 
		{
			Destroy (ball);

			playerPoints += 3;
			turn += 1;

			checkWinner (); //Has the player accrued 10 points and won?



			(Instantiate (ballPref, new Vector3 (paddleObj.transform.position.x + 2, paddleObj.transform.position.y, 0), Quaternion.identity) as GameObject).transform.parent = paddleObj;

			int rand = Random.Range(0,1);

			if (PlayerScore.turn <= 5) 
				for (int i = 0; i < 1; i++)
					Instantiate (greenBallPref, new Vector3 (0, Random.Range (-12, 12), 0), Quaternion.identity);
			else if (PlayerScore.turn <= 10)
				for (int i = 0; i < 3; i++)
					Instantiate (greenBallPref, new Vector3 (0, Random.Range(-12, 12), 0), Quaternion.identity);
			else if (PlayerScore.turn <= 15)
				for (int i = 0; i < 4; i++)
					Instantiate (greenBallPref, new Vector3 (0, Random.Range(-12, 12), 0), Quaternion.identity);
			else if (PlayerScore.turn <= 20)
				for (int i = 0; i < 5; i++)
					Instantiate (greenBallPref, new Vector3 (0, Random.Range(-12, 12), 0), Quaternion.identity);
			else if (PlayerScore.turn <= 25)
				for (int i = 0; i < 6; i++)
					Instantiate (greenBallPref, new Vector3 (0, Random.Range(-12, 12), 0), Quaternion.identity);
			else if (PlayerScore.turn <= 30)
				for (int i = 0; i < 7; i++)
					Instantiate (greenBallPref, new Vector3 (0, Random.Range(-12, 12), 0), Quaternion.identity);
			else if (PlayerScore.turn <= 35)
				for (int i = 0; i < 8; i++)
					Instantiate (greenBallPref, new Vector3 (0, Random.Range(-12, 12), 0), Quaternion.identity);
			else if (PlayerScore.turn <= 40)
				for (int i = 0; i < 9; i++)
					Instantiate (greenBallPref, new Vector3 (0, Random.Range(-12, 12), 0), Quaternion.identity);
			else if (PlayerScore.turn <= 45)
				for (int i = 0; i < 10; i++)
					Instantiate (greenBallPref, new Vector3 (0, Random.Range(-12, 12), 0), Quaternion.identity);
			else if (PlayerScore.turn <= 50)
				for (int i = 0; i < 11; i++)
					Instantiate (greenBallPref, new Vector3 (0, Random.Range(-12, 12), 0), Quaternion.identity);


		


		} 


	}

	void checkWinner()
	{
		if (playerPoints >= 50) //10 points to win
		{
			result.text = "YOU WIN!";
			returnMenu.text = "RETURN TO MENU";
			playAgain.text = "PLAY AGAIN";
			Time.timeScale = 0;
		}
			
	}




}
