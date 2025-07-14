using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomSlider : MonoBehaviour
{
    public Slider slider;
    public float lerpSpeed = 5; 
    private float targetValue;
    // Start is called before the first frame update
    void Start()
    {
        targetValue = slider.value;
    }

    // Update is called once per frame
    void Update()
    {
        if (slider.value != targetValue)
        {
            slider.value = Mathf.Lerp(slider.value, targetValue, Time.deltaTime * lerpSpeed);
        }
    }
    public void SetSliderValue(float value)
    {
        targetValue = value;
    }
}
