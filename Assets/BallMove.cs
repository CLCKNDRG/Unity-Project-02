using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEditorInternal;
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
        pos = gameObject.transform.position;

        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.position = new Vector3(pos.x -= 0.01f, pos.y, pos.z);
        }
        if (Input.GetKey(KeyCode.LeftControl))
        {
            gameObject.transform.position = new Vector3(pos.x, pos.y, pos.z -= 0.01f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.position = new Vector3(pos.x += 0.01f, pos.y, pos.z);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            gameObject.transform.position = new Vector3(pos.x, pos.y, pos.z += 0.01f);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            gameObject.transform.position = new Vector3(pos.x, pos.y += 3, pos.z);
        }
        if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.position = new Vector3(pos.x, pos.y -= 1, pos.z);
        }

        //Collision Check
        if (pos.y <= 0)
        {
            gameObject.transform.position = new Vector3(pos.x, 1, pos.z);
        }

    }
}
