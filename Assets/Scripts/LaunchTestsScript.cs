using UnityEngine;
using System.Collections;

public class LaunchTestsScript : MonoBehaviour {
    public GameObject gameManagerObject;

    bool isTriggered;
    GameManager gameManagerScript;
	// Use this for initialization
	void Start () {
        gameManagerScript = gameManagerObject.GetComponent<GameManager>();

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space) && isTriggered)
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(-0.8f, 0.2f, 0) * 35, ForceMode.Impulse);
        }
    }
    void OnTriggerEnter(Collider coll)
    {
        if (coll.CompareTag("LaunchArea"))
        {
            isTriggered = true;
        }

        if (coll.CompareTag("OutOfBounds"))
        {
            gameManagerScript.ResetBall();
        }
    }
    void OnTriggerExit(Collider coll)
    {
        if (coll.CompareTag("LaunchArea"))
        {
            isTriggered = false;
        }
    }
}
