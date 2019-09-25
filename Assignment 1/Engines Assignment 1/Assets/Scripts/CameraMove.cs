using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{

    float speed = 0.5f;

    float speedH = 2.0f;
    float speedV = 2.0f;

    float yaw = 0.0f;
    float pitch = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("i"))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + speed);
        }
        else if (Input.GetKeyDown("k"))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - speed);
        }
        else if (Input.GetKeyDown("j"))
        {
            transform.position = new Vector3(transform.position.x - speed, transform.position.y, transform.position.z);
        }
        else if (Input.GetKeyDown("l"))
        {
            transform.position = new Vector3(transform.position.x + speed, transform.position.y, transform.position.z);
        }
        //yaw += speedH * Input.GetAxis("Mouse X");
        //pitch -= speedV * Input.GetAxis("Mouse Y");

        //transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
        
    }
}
