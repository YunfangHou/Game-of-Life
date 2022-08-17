using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CreateLifeButtonScript : MonoBehaviour
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
        float x = float.Parse(GameObject.Find("InputX/Text").GetComponent<Text>().text);
        float y = float.Parse(GameObject.Find("InputY/Text").GetComponent<Text>().text);
        CreateCube(x,y);

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
