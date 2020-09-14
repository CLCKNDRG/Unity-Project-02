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
    void Update()
    {
        //pos에 오브젝트의 위치 대입
        pos = gameObject.transform.position;

        //A키를 누르고 있을 경우
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.position = new Vector3(pos.x -= 0.01f, pos.y, pos.z);
        }
        //왼쪽 컨트롤 키를 누르고 있을 경우
        if (Input.GetKey(KeyCode.LeftControl))
        {
            gameObject.transform.position = new Vector3(pos.x, pos.y, pos.z -= 0.01f);
        }
        //D키를 누르고 있을 경우
        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.position = new Vector3(pos.x += 0.01f, pos.y, pos.z);
        }
        //스페이스키를 누르고 있을 경우
        if (Input.GetKey(KeyCode.Space))
        {
            gameObject.transform.position = new Vector3(pos.x, pos.y, pos.z += 0.01f);
        }
        //W키를 누르고 있을 경우
        if (Input.GetKeyDown(KeyCode.W))
        {
            gameObject.transform.position = new Vector3(pos.x, pos.y += 3, pos.z);
        }
        //S키를 누르고 있을 경우
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
