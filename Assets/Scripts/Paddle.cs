using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour
{
    public Vector3 moveRotationInDegree;
    public KeyCode paddleKey;

    private bool keepUp;

    private float timerFinish = 0.05f;
    private float timer = 0;

    private Quaternion originalRotation;
    private Rigidbody rb;
    // Use this for initialization
    void Start()
    {
        originalRotation = transform.localRotation;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(paddleKey))
        {
            keepUp = true;
        }
        if (Input.GetKeyUp(paddleKey))
        {
            keepUp = false;
        }
    }
    void FixedUpdate()
    {
        if (keepUp)
        {
            transform.localRotation = Quaternion.Euler(Vector3.Lerp(transform.localEulerAngles, moveRotationInDegree, Time.deltaTime * 25));
            //timer += Time.deltaTime;
            //if (timerFinish > timer)
            //{
            //}
        }
        if (!keepUp && transform.localRotation != originalRotation)
        {
            timer = 0;
            transform.localRotation = originalRotation;
        }
    }
    void OnCollisionEnter(Collision coll)
    {
        if (keepUp)
            coll.rigidbody.AddForce(Vector3.Normalize(coll.impulse) * 10, ForceMode.Impulse);
    }
}