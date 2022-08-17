using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ResetButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(OnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnClick()
    {
        GameObject.Find("GameStartButton").GetComponent<GameStartButtonScript>().gameStart = false;
        for (int x = 0; x < 100; x++)
        {
            for (int y = 0; y < 100; y++)
            {
                if (GameObject.Find("Cube_" + x + "_" + y))
                {
                    Destroy(GameObject.Find("Cube_" + x + "_" + y));

                }
            }
        }
    }
}
