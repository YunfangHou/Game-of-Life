using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadCubeScript : MonoBehaviour
{
    float[][] newCubeList = new float[2][];
    int newCubeAmount = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("OneTermButton").GetComponent<OneTermButtonScript>().frame % 3 == 2)
        {
            for (int i = 0; i < newCubeAmount; i++)
            {
                float x = newCubeList[i][0];
                float y = newCubeList[i][1];
                CreateCube(x, y);
            }

            newCubeAmount = 0;
        }

        if ((GameObject.Find("GameStartButton").GetComponent<GameStartButtonScript>().gameStart
             && GameObject.Find("OneTermButton").GetComponent<OneTermButtonScript>().frame % 3 == 1)
            || GameObject.Find("OneTermButton").GetComponent<OneTermButtonScript>().frame == 1)
        {
            // mainly detect for the dead cells
            for (int x = -10; x < 10; x++)
            {
                for (int y = -10; y < 10; y++)
                {
                    if (!GameObject.Find("Cube_" + x + "_" + y))
                    {
                        GameObject cube1 = GameObject.Find("Cube_" + (x - 1) + "_" + (y + 1));
                        GameObject cube2 = GameObject.Find("Cube_" + x + "_" + (y + 1));
                        GameObject cube3 = GameObject.Find("Cube_" + (x + 1) + "_" + (y + 1));
                        GameObject cube4 = GameObject.Find("Cube_" + (x - 1) + "_" + y);
                        GameObject cube5 = GameObject.Find("Cube_" + (x + 1) + "_" + y);
                        GameObject cube6 = GameObject.Find("Cube_" + (x - 1) + "_" + (y - 1));
                        GameObject cube7 = GameObject.Find("Cube_" + x + "_" + (y - 1));
                        GameObject cube8 = GameObject.Find("Cube_" + (x + 1) + "_" + (y - 1));

                        GameObject[] cubes = new GameObject[8] {cube1, cube2, cube3, cube4, cube5, cube6, cube7, cube8};

                        int liveCellAmount = 0;
                        foreach (GameObject cube in cubes)
                        {
                            if (cube)
                            {
                                liveCellAmount++;
                            }
                        }

                        if (liveCellAmount == 3)
                        {
                            newCubeList[newCubeAmount] = new float[] {x, y};
                            newCubeAmount++;
                        }
                    }
                }
            }
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