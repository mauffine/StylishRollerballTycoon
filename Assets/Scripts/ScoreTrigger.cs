using UnityEngine;
using System.Collections;

public class ScoreTrigger : MonoBehaviour {

	public int ScoreValue;
	public bool DoesScore = true;
	public bool TimedRollover = false;
	private float RolloverTimer = 0;

	public GameManager GM;
	// Use this for initialization
	void Start ()
	{
		//GM = GameObject.Find("Plane").GetComponent<GameManager>();
		//ScoreValue = 100;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (RolloverTimer > 0)
			RolloverTimer -= Time.deltaTime;
		else if (RolloverTimer <= 0)
			DoesScore = true;
	}

	void OnTriggerEnter(Collider coll)
	{
		if(TimedRollover)
		{
			RolloverTimer = 10;
			DoesScore = false;
		}

		if(DoesScore)
			GM.UpdateScore(ScoreValue);
	}

	void OnCollisionEnter(Collision coll)
	{
		GM.UpdateScore(ScoreValue);
	}
}
