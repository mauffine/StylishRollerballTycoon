using UnityEngine;
using System.Collections;

public class ScoreTrigger : MonoBehaviour {

	public int ScoreValue;

	public GameManager GM;
	// Use this for initialization
	void Start ()
	{
		ScoreValue = 100;
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void OnTriggerEnter(Collider coll)
	{
		GM.UpdateScore(ScoreValue);
	}

	void OnCollisionEnter(Collision coll)
	{
		GM.UpdateScore(ScoreValue);
	}
}
