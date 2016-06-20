using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public int ScoreTotal = 0;

	//Make private / hidden towards the end
	public int BallsRemaining = 6;

    //BallPrefab
    public GameObject BallPrefab;
	//BallScript

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
        //test button
        if (Input.GetKeyDown(KeyCode.W))
            ResetBall();
	}

	public void UpdateScore(int Score)
	{
		ScoreTotal += Score;
	}
	public void ResetScore()
	{
		ScoreTotal = 0;
	}
    public void ResetBall()
    {
        if (BallsRemaining > 0)
        {
            //resetPos;
            BallPrefab.transform.position = new Vector3(4.427f, -1.514f, 2.368f);
            BallPrefab.GetComponent<Rigidbody>().velocity = Vector3.zero;
            BallsRemaining--;
        }
    }
}
