using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnObject : MonoBehaviour
{
    public InputField xPos;
    public InputField yPos;
    public InputField zPos;

    public GameObject p;

    float x;
    float y;
    float z;
    public void Spawn()
    {
         x = float.Parse(xPos.text);

         y = float.Parse(yPos.text);

         z = float.Parse(zPos.text);

        Instantiate(p, new Vector3(x,y,z), Quaternion.identity);
    }
}
