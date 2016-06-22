using UnityEngine;
using System.Collections;

public class OnClick : MonoBehaviour {

	private Quaternion GamePos = new Quaternion(42, 90, 0, 0);
	private Quaternion MenuPos = new Quaternion(7, 90, 0, 0);
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

		if (GameMove == true && cam.transform.localRotation != GamePos)
		{
			PlayButton.SetActive(false);
			QuitButton.SetActive(false);

			cam.transform.localRotation = Quaternion.Lerp(cam.transform.localRotation, GamePos, 0.05f);
			if(cam.transform.localRotation.x >= 41.9)
				cam.transform.localRotation = GamePos;

			PauseButton.SetActive(true);
		}
		else if(GameMove == false && cam.transform.localRotation != MenuPos)
		{
			PauseButton.SetActive(false);

			cam.transform.localRotation = Quaternion.Lerp(cam.transform.localRotation, MenuPos, 0.05f);
			if (cam.transform.localRotation.x <= 7.1f)
				cam.transform.localRotation = MenuPos;

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
