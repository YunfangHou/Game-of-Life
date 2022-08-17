using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    private bool shouldDestroy;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (shouldDestroy)
        {
            Destroy(gameObject);
        }

        if ((GameObject.Find("GameStartButton").GetComponent<GameStartButtonScript>().gameStart
             && GameObject.Find("OneTermButton").GetComponent<OneTermButtonScript>().frame % 3 == 1)
            || GameObject.Find("OneTermButton").GetComponent<OneTermButtonScript>().frame == 1)
        {
            float x = gameObject.transform.position.x;
            float y = gameObject.transform.position.y;
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

            if (liveCellAmount < 2 || liveCellAmount > 3)
            {
                shouldDestroy = true;
            }
        }
    }
}