using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public int ScoreTotal = 0;

	//Make private / hidden towards the end
	public int BallsRemaining = 6;
	//BallScript

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{

	}

	public void UpdateScore(int Score)
	{
		ScoreTotal += Score;
	}
	public void ResetScore()
	{
		ScoreTotal = 0;
	}
}
