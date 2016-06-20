using UnityEngine;
using System.Collections;

public class OnClick : MonoBehaviour {

	private Vector3 GamePos = new Vector3(6.8f, 5.2f, 0);
	private Vector3 MenuPos = new Vector3(0, -1.5f, 0);

	bool CameraMove = false;

	public Camera cam;
	// Use this for initialization
	void Start ()
	{
	
	}

	// Update is called once per frame
	void Update()
	{
		if (CameraMove && cam.transform.position != GamePos)
		{
			cam.transform.position = Vector3.Lerp(cam.transform.position, GamePos, Time.deltaTime);
			cam.transform.LookAt(MenuPos);
		}
	}
	public void StartFunction()
	{
		CameraMove = true;
	}
}
