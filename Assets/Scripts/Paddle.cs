using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour
{
    public Vector3 moveRotationInDegree;
    public KeyCode paddleKey;
    public GameObject Ball;

    private bool keepUp;

    private float timerFinish = 0.05f;
    private float timer = 0;

    private Quaternion originalRotation;
    private Rigidbody rb;

    bool ballColliding;
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
            if (ballColliding)
                Ball.GetComponent<Rigidbody>().AddForce(new Vector3(0.8f, 0.2f, 0) * 50, ForceMode.Impulse);
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
        }
        if (!keepUp && transform.localRotation != originalRotation)
        {
            timer = 0;
            transform.localRotation = originalRotation;
        }
    }
    void OnCollisionEnter(Collision coll)
    {
        if(coll.collider.CompareTag("Ball"))
            ballColliding = true;
    }
    void OnCollisionExit(Collision coll)
    {
        if (coll.collider.CompareTag("Ball"))
            ballColliding = false;
    }
}