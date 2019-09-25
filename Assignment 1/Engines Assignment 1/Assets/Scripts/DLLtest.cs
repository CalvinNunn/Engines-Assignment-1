using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
using CommandPattern;

public class DLLtest : MonoBehaviour
{
    InputHandler i;

    const string DLL_NAME = "A1_DLL";

    [DllImport(DLL_NAME)]
    private static extern int wPressed();

    [DllImport(DLL_NAME)]
    private static extern int aPressed();

    [DllImport(DLL_NAME)]
    private static extern int sPressed();

    [DllImport(DLL_NAME)]
    private static extern int dPressed();

    //////////

    [DllImport(DLL_NAME)]
    private static extern int wnotPressed();

    [DllImport(DLL_NAME)]
    private static extern int anotPressed();

    [DllImport(DLL_NAME)]
    private static extern int snotPressed();

    [DllImport(DLL_NAME)]
    private static extern int dnotPressed();

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            Debug.Log(wPressed() + 2);
        }

    }

}
