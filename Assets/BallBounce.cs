using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : MonoBehaviour
{
    // Set Variables
    Vector3 pos;
    public float bounceSpeed = 1.0f;
    public float bounceAmount = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        //pos에 오브젝트의 위치 대입
        pos = gameObject.transform.position;

        //Bounce
        gameObject.transform.position = new Vector3(pos.x, Mathf.Sin(Mathf.Clamp01((Time.time * bounceSpeed) % 1) * Mathf.PI) * bounceAmount + 0.5f, pos.z);
    }

}
