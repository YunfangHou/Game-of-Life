using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStartButtonScript : MonoBehaviour
{
    public bool gameStart;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(OnClick);
        Application.targetFrameRate = 50;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnClick()
    {
        gameStart = true;
    }
}
