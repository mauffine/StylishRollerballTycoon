using UnityEngine;
using System.Collections;

public class PaddleLeft : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Z))
            Vector3.Lerp(transform.eulerAngles, new Vector3(45, 0, 0), 1);
        //transform.localEulerAngles += new Vector3(45, 0, 0);
        if (Input.GetKey(KeyCode.X))
            Vector3.Lerp(transform.eulerAngles, new Vector3(0, 0, 0), 1);
    }
}
