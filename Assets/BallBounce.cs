using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : MonoBehaviour
{
    // Set Variables
    Vector3 pos;
    static public float bounceSpeed = 1.0f;
    static public float bounceHeight = 1.0f;

    // Set Acceleration and Gravity
    public float Accelerate = 1.0001f;
    public float Gravity = 0.999f;

    private float ballSpeed;
    private float ballMaxHeight;
    private float ballHeight;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //pos에 오브젝트의 위치 대입
        pos = gameObject.transform.position;

        //Bounce Reduction
        ballHeight = Mathf.Sin(Mathf.Clamp01((Time.time * ballSpeed) % 1.0f) * Mathf.PI);
        gameObject.transform.position = new Vector3(pos.x, ballHeight * ballMaxHeight + 0.5f, pos.z);

        //Accelerate Drop Speed and Reduce Max Height
        ballSpeed *= Accelerate;
        ballMaxHeight *= Gravity;

        //Bounce Stop Control
        if (ballMaxHeight <= 0.01f)
            ballMaxHeight = 0.0f;

        //Clear Bounce Status
        if (Input.GetMouseButtonDown(0))
        {
            ballSpeed = bounceSpeed;
            ballMaxHeight = bounceHeight;
        }
    }
}
