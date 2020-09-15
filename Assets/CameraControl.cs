using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    // Set Variables
    public float sensitivity = 10f; //민감도
    public float maxYAngle = 80f; //상하각도 제한
    private Vector2 currentRotation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentRotation.x += Input.GetAxis("Mouse X") * sensitivity; //X축 회전
        currentRotation.y -= Input.GetAxis("Mouse Y") * sensitivity; //Y축 회전

        //X축은 360 회전이 가능함
        currentRotation.x = Mathf.Repeat(currentRotation.x, 360);
        //Y축 회전 제한
        currentRotation.y = Mathf.Clamp(currentRotation.y, -maxYAngle, maxYAngle);
        
        //Z축 잠금
        Camera.main.transform.rotation = Quaternion.Euler(currentRotation.y, currentRotation.x, 0);
    }
}
