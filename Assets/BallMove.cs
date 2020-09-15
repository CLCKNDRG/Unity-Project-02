using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEditorInternal;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    // Set Variables
    Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {    

    }

    // Update is called once per frame
    void Update()
    {
        //pos에 오브젝트의 위치 대입
        pos = gameObject.transform.position;

        //Set Direction
        Vector3 dir = Camera.main.transform.localRotation * Vector3.forward;
        transform.localRotation = new Quaternion(0, transform.localRotation.y,
                                                 0, transform.localRotation.w);   //lock x and z
        gameObject.transform.Translate(dir * 0.01f);    //Move Ball

        //Collision Check
        if (pos.y <= 0)
        {
            gameObject.transform.position = new Vector3(pos.x, 1, pos.z);
        }

    }
}
