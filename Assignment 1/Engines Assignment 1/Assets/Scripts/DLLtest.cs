using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.UI;

public class DLLtest : MonoBehaviour
{
    public GameObject p;
    public GameObject cubeContainer;
    public PlayerControl player;
    public Button saveB;
    public Button loadB;

    const string DLL_NAME = "A1DLL";

    [DllImport(DLL_NAME)]
    private static extern void saveFile(float x, float y, float z, float sX, float sY, float sZ);

    [DllImport(DLL_NAME)]
    private static extern int loadFileX(int i);

    [DllImport(DLL_NAME)]
    private static extern void clearFile();

    [DllImport(DLL_NAME)]
    private static extern int loadFileY(int i);

    [DllImport(DLL_NAME)]
    private static extern int loadFileZ(int i);

    [DllImport(DLL_NAME)]
    private static extern int loadFileSX(int i);

    [DllImport(DLL_NAME)]
    private static extern int loadFileSY(int i);

    [DllImport(DLL_NAME)]
    private static extern int loadFileSZ(int i);

    [DllImport(DLL_NAME)]
    private static extern int getLines();


    // Update is called once per frame

    void Start()
    {
        
        Button bt = saveB.GetComponent<Button>();
        bt.onClick.AddListener(SaveOnClick);

        Button bl = loadB.GetComponent<Button>();
        bl.onClick.AddListener(LoadOnClick);
    }

    void SaveOnClick()
    {
        clearFile();
        saveFile(0, 0, 0, 0, 0, 0);
        //dummy data fills first position
        for (int i = 0; i < cubeContainer.transform.childCount; i++)
        {
            saveFile(cubeContainer.transform.GetChild(i).position.x, cubeContainer.transform.GetChild(i).position.y, cubeContainer.transform.GetChild(i).position.z,
                cubeContainer.transform.GetChild(i).localScale.x, cubeContainer.transform.GetChild(i).localScale.y, cubeContainer.transform.GetChild(i).localScale.z);
        }


    }

    void LoadOnClick()
    {
        


        //string data = "10,10,10";


        //player.transform.position = new Vector3(loadX, loadY, loadZ);
        //player.transform.position = new Vector3(loadX, loadY, loadZ);

        for(int i = 0; i < getLines(); i++)
        {
            int x = loadFileX(i);
            int y = loadFileY(i);
            int z = loadFileZ(i);

            int sX = loadFileSX(i);
            int sY = loadFileSY(i);
            int sZ = loadFileSZ(i);
                        
            GameObject newObj = Instantiate(p, new Vector3(x, y, z), Quaternion.identity);

            newObj.transform.localScale = new Vector3 (sX, sY, sZ);

            //newObj.transform.parent = cubeContainer.transform;

            newObj.GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);

        }
        
    }

    void save()
    {
        clearFile();
        for (int i = 0; i < cubeContainer.transform.childCount; i++)
        {
            saveFile(cubeContainer.transform.GetChild(i).position.x, cubeContainer.transform.GetChild(i).position.y, cubeContainer.transform.GetChild(i).position.z,
                cubeContainer.transform.GetChild(i).localScale.x, cubeContainer.transform.GetChild(i).localScale.y, cubeContainer.transform.GetChild(i).localScale.z);
        }
    }

}
