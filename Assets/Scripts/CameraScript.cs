using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Camera>().orthographicSize = 5;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Camera>().orthographicSize = GameObject.Find("Slider").GetComponent<SliderScript>().value;
    }
}
