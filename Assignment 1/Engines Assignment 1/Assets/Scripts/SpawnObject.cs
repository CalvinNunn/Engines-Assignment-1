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

    public List<GameObject> p;
    public GameObject spawnedObject;

    public List<Vector3> positions;

    public List<Vector3> cubePositions;

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

        for (int i = 0; i < positions.Count; i++)
        {
            positions[i] = new Vector3(xP, yP, zP);

        }

        positions = getPositions();

        for (int i = 0; i < p.Count; i++)
        {
            p[i] = spawnedObject;

            //without flyweight
            //p[i].transform.position = getPositions()[i];

            //with flyweight
            p[i].transform.position = cubePositions[i];

            GameObject newObj = Instantiate(p[i], new Vector3(xP, yP, zP), Quaternion.identity);

            cubePositions.Add(newObj.transform.position);

            newObj.transform.localScale = new Vector3(xS, yS, zS);

            newObj.GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);

            p[i] = newObj;
        }
    }
    List<Vector3> getPositions()
    {
        //Create a new list
        List<Vector3> getPos = new List<Vector3>();

        //Add body part positions to the list
        for (int i = 0; i < positions.Count; i++)
        {
            getPos.Add(new Vector3());
        }

        return getPos;
    }


}
