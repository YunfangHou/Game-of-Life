using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OneTermButtonScript : MonoBehaviour
{
    public int frame;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(OnClick);
        frame = 2;
    }

    // Update is called once per frame
    void Update()
    {
        frame++;
    }
    
    private void OnClick()
    {
        frame = 0;
    }
}
