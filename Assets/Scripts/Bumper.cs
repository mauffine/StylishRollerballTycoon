using UnityEngine;
using System.Collections;

public class Bumper : MonoBehaviour
{
    public float m_bumperForce;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision coll)
    {

        coll.rigidbody.AddForce(Vector3.Normalize(coll.impulse) * m_bumperForce, ForceMode.Impulse);
        //coll.rigidbody.AddForce(Vector3.Normalize(coll.transform.position - transform.position) * m_bumperForce, ForceMode.Impulse);
    }
}
