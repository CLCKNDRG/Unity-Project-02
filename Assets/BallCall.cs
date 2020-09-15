using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCall: MonoBehaviour
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

        if (Input.GetMouseButton(0))
        {
            gameObject.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 2, Screen.height / 2, 2));
        }

    }
}
