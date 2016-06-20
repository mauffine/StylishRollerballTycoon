using UnityEngine;
using System.Collections;

public class PaddleLeft : MonoBehaviour {
    public Vector3 RotateTo;
    public float RotateBy;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Z))
            transform.localEulerAngles += new Vector3(45, 0, 0);
        if (Input.GetKeyDown(KeyCode.X))
            transform.localEulerAngles -= new Vector3(45, 0, 0);
    }
}
