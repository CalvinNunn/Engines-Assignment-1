using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    Rigidbody r;
    public float speed = 5f;
    public float hor;
    public float ver;
    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        hor = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical");

    }

    public void moveF()
    {
        r.AddForce(new Vector3(0, 0, ver) * speed);
    }

    public void mL()
    {
        Debug.Log("TESTL");
        r.AddForce(new Vector3(hor, 0, 0) * speed);
    }

    public void mR()
    {
        Debug.Log("TESTR");

        r.AddForce(new Vector3(hor, 0, 0) * speed);
    }

    public void moveB()
    {
        r.AddForce(new Vector3(0, 0, ver) * speed);
    }
}
