using UnityEngine;
using System.Collections;

public class Bumper : MonoBehaviour
{
    public float m_bumperForce;
    public AudioClip[] m_trumbBumpSounds;
    public bool isBumper;

    // Use this for initialization
    void Start () {
	
	}
	
	
	void Update () {
	
	}

    void OnCollisionEnter(Collision coll)
    {
        if (isBumper)
            GetComponent<AudioSource>().PlayOneShot(m_trumbBumpSounds[Random.Range(0, m_trumbBumpSounds.Length)]);
        coll.rigidbody.AddForce(Vector3.Normalize(coll.impulse) * m_bumperForce, ForceMode.Impulse);
        //coll.rigidbody.AddForce(Vector3.Normalize(coll.transform.position - transform.position) * m_bumperForce, ForceMode.Impulse);
    }
}
