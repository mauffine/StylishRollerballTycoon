using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
    public Vector3 resetBallPos;
	public int ScoreTotal = 0;
	public int RolloverCount = 0;
	public float TrumpTime = 0;

	public GameObject[] Rollovers;

    public GameObject score, balls;

	//Make private / hidden towards the end
	public int BallsRemaining = 6;

    //BallPrefab
    public GameObject BallPrefab;
	public GameObject GodEmperorTrump;
    //public GameObject 
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
        score.GetComponent<TextMesh>().text = ScoreTotal.ToString();
        balls.GetComponent<TextMesh>().text = BallsRemaining.ToString();

		//Trump head raise
		if (RolloverCount == 4)
		{
			RolloverCount = 0;
			TrumpTime = 20.0f;
		}
		PraiseOurLordAndSavior();
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
            BallPrefab.transform.position = resetBallPos;
            BallPrefab.GetComponent<Rigidbody>().velocity = Vector3.zero;
            BallsRemaining--;
        }
    }
	private void PraiseOurLordAndSavior()
	{
		if (GodEmperorTrump.transform.position.y <= 18 && TrumpTime > 0)
			GodEmperorTrump.transform.position += new Vector3(0, 1, 0) * Time.deltaTime / 3;
		else if (GodEmperorTrump.transform.position.y >= 14.5f && TrumpTime <= 0)
			GodEmperorTrump.transform.position -= new Vector3(0, 1, 0) * Time.deltaTime / 3;
		if (TrumpTime > 0)
			TrumpTime -= Time.deltaTime;
		else if(TrumpTime <= 0)
		{
			ResetRollover();
		}
	}

	public void ResetRollover()
	{
		for (int i = 0; i < Rollovers.Length; i++)
		{
			TrumpTrigger temp = Rollovers[i].GetComponent<TrumpTrigger>();

            temp.ActiveTime = 10;
        }
	}
}
