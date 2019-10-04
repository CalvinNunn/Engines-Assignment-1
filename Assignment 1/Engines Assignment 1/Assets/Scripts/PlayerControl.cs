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
        r.AddForce(new Vector3(hor, 0, 0) * speed);
    }

    public void mR()
    {
        r.AddForce(new Vector3(hor, 0, 0) * speed);
    }

    public void moveB()
    {
        r.AddForce(new Vector3(0, 0, ver) * speed);
    }
    public void jump()
    {
        r.AddForce(transform.up * 8, ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Key")
        {
            #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
            #else
          Application.Quit();
            #endif
        }
    }
}
