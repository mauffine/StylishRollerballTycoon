using UnityEngine;
using System.Collections;

public class OnClick : MonoBehaviour {

	private Vector3 GamePos = new Vector3(6.8f, 5.2f, 0);
	private Vector3 LookPos = new Vector3(0, -1.5f, 0);
	public Vector3 MenuPos = new Vector3(-2, 0.8f, 0);
	public float CameraSpeed = 1;

	public GameObject PlayButton;
	public GameObject QuitButton;
	public GameObject PauseButton;

	public bool GameMove = false;

	public Camera cam;
	// Use this for initialization
	void Start ()
	{
	
	}

	// Update is called once per frame
	void Update()
	{
		GetInput();

		if (GameMove == true && cam.transform.position != GamePos)
		{
			PlayButton.SetActive(false);
			QuitButton.SetActive(false);

			cam.transform.position = Vector3.LerpUnclamped(cam.transform.position, GamePos, 0.05f);
			cam.transform.LookAt(LookPos);
			if(cam.transform.position.x >= 6.799f && cam.transform.position.y >= 5.199f)
				cam.transform.position = GamePos;

			PauseButton.SetActive(true);
		}
		else if(GameMove == false && cam.transform.position != MenuPos)
		{
			PauseButton.SetActive(false);

			cam.transform.position = Vector3.LerpUnclamped(cam.transform.position, MenuPos, 0.05f);
			cam.transform.LookAt(LookPos);
			if (cam.transform.position.y <= -1.51f)
				cam.transform.position = MenuPos;

			PlayButton.SetActive(true);
			QuitButton.SetActive(true);
		}
	}
	public void StartFunction()
	{
		GameMove = true;
	}
	public void QuitFunction()
	{
		Application.Quit();
	}
	public void PauseFunction()
	{
		GameMove = false;
	}

	private void GetInput()
	{
		if(Input.GetKey(KeyCode.Escape))
		{
			PauseFunction();
		}
		if(Input.GetKey(KeyCode.Return))
		{
			StartFunction();
		}
	}
}
