using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnObject : MonoBehaviour
{
    public InputField xPos;
    public InputField yPos;
    public InputField zPos;

    public InputField xScale;
    public InputField yScale;
    public InputField zScale;

    public GameObject p;

    float xP;
    float yP;
    float zP;

    float xS;
    float yS;
    float zS;
    public void Spawn()
    {
         xP = float.Parse(xPos.text);

         yP = float.Parse(yPos.text);

         zP = float.Parse(zPos.text);

         xS = float.Parse(xScale.text);
         
         yS = float.Parse(yScale.text);
         
         zS = float.Parse(zScale.text);

       GameObject newObj = Instantiate(p, new Vector3(xP,yP,zP), Quaternion.identity);
        newObj.transform.localScale = new Vector3(xS, yS, zS);
    }
}
