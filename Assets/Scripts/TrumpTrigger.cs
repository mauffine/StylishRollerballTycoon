﻿using UnityEngine;
using System.Collections;

public class TrumpTrigger : MonoBehaviour
{

	public GameObject Game_Manager;
	private GameManager GM;
	public bool isActive = true;
	public float ActiveTime = 0;

	// Use this for initialization
	void Start()
	{
		GM = Game_Manager.GetComponent<GameManager>();
	}

	// Update is called once per frame
	void Update()
	{
		if (ActiveTime > 0)
			ActiveTime -= Time.deltaTime;
		else
		{
			for (int i = 0; i < GM.Rollovers.Length; i++)
			{
				GM.Rollovers[i].GetComponent<TrumpTrigger>().isActive = false;
			}
		}
	}

	void OnTriggerEnter(Collider coll)
	{
		if (isActive)
		{
			GM.RolloverCount += 1;
			isActive = false;

			ActiveTime = 40;
		}
	}
}