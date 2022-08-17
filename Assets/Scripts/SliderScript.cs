using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    public float value;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Slider>().value = 5;
    }

    // Update is called once per frame
    void Update()
    {
        value = GetComponent<Slider>().value;
    }
}
