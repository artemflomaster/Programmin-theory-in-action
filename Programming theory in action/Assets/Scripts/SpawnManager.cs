using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject pillar;
    public GameObject cube;

    private int cubesAmount = 20;
  
        
    void Start()
         
    {
        CreateFourOOPPillars();  //ABSTRACTION
        CreateCubes();
    }

    private void CreateFourOOPPillars()
    {
        for (int i = 0; i < 4; i++)
        {
            GameObject justInstantiated = Instantiate(pillar, SpawnPos(i), pillar.transform.rotation);
            justInstantiated.GetComponent<Renderer>().material.color = pillarColor(i);
        }
    }

    private Vector3 SpawnPos(int pillarID)
    {
        if (pillarID == 0)
        {
            return new Vector3(-1.75f, 0, 1.5f); //1st pillar position (Abstraction pillar)
        }
        if (pillarID == 1)
        {
            return new Vector3(-0.5f, 0, 1.5f); //2nd pillar position (Inheratance pillar)
        }
        if (pillarID == 2)
        {
            return new Vector3(0.5f, 0, 1.5f); //3rd pillar position (Polymorphism pillar)
        }
        if (pillarID == 3)
        {
            return new Vector3(1.75f, 0, 1.5f); //4th pillar position (Incapsulation Pillar)
        }
        else {

            Debug.Log("Wrong argument in pillar ID");
            return new Vector3(10,10,10);
        }
    }

    private Color pillarColor(int pillarID)
    {
        if (pillarID == 0)
        {
            return new Color32(90, 65, 179, 255); //1st pillar position (Abstraction pillar)
        }
        if (pillarID == 1)
        {
            return new Color32(83, 217, 217, 255); //2nd pillar position (Inheratance pillar)
        }
        if (pillarID == 2)
        {
            return new Color32(255, 55, 126, 255); //3rd pillar position (Polymorphism pillar)
        }
        if (pillarID == 3)
        {
            return Color.yellow; //4th pillar position (Incapsulation Pillar)
        }
        else
        {

            Debug.Log("Wrong argument in pillar ID");
            return Color.black;
        }
    }
    private void CreateCubes()
    {
        for (int i = 0; i <= cubesAmount; i++)
        {
            Instantiate(cube, CubePos(), transform.rotation);
        }
    }
    private Vector3 CubePos()
    {
        float x = Random.Range(0.7f, 1.0f);
        float y = -0.45f + Random.Range(0f, 1f);
        float z = 0.75f;
        return new Vector3(x, y, z);
    }
}



