using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeleteLifeButtonScript : MonoBehaviour
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
        Destroy(GameObject.Find("Cube_" + x + "_" + y));
    }
    
}