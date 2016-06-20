using UnityEngine;
using System.Collections;

public class LaunchTestsScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(-0.8f, 0.2f, 0) * 13, ForceMode.Impulse);
        }
	}
}
