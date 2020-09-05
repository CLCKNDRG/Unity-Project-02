using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 pos;
    void Start()
    {

    }

    // Update is called once per frame
    // 과제 S를 누를 때 뚫리지 않도록 하라
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            pos = gameObject.transform.position;
            gameObject.transform.position = new Vector3(pos.x -= 0.01f, pos.y, pos.z);
        }
        if (Input.GetKey(KeyCode.S))
        {
            pos = gameObject.transform.position;
            gameObject.transform.position = new Vector3(pos.x, pos.y, pos.z -= 0.01f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            pos = gameObject.transform.position;
            gameObject.transform.position = new Vector3(pos.x += 0.01f, pos.y, pos.z);
        }
        if (Input.GetKey(KeyCode.W))
        {
            pos = gameObject.transform.position;
            gameObject.transform.position = new Vector3(pos.x, pos.y, pos.z += 0.01f);
        }

    }
}
