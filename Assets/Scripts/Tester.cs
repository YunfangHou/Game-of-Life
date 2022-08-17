using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tester : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            print((bool) GameObject.Find("Cube_9_9"));

            CreateCube(9, 9);
            
            print((bool) GameObject.Find("Cube_9_9"));
        }
    }

    private void CreateCube(float x, float y)
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.name = "Cube_" + x + "_" + y;
        cube.AddComponent<CubeScript>();
        cube.GetComponent<BoxCollider>().enabled = false;
        cube.transform.localScale = new Vector3(0.9f, 0.9f, 0.9f);
        cube.GetComponent<Renderer>().material.color = Color.blue;
        cube.transform.position = new Vector3(x, y, 0f);
    }
}