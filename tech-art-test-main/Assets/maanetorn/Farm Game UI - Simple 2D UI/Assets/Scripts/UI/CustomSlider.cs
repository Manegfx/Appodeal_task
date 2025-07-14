using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomSlider : MonoBehaviour
{
    public Slider slider;
    public float lerpSpeed = 5; 
    private float targetValue;
    public AudioSource audioSource;
    private bool sfxactivated = false;

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
            if (Mathf.Abs(slider.value - targetValue) <= 0.01f)
            {
                slider.value = targetValue;
            }
        }
        if(slider.value == 1 && sfxactivated == false)
        {
            sfxactivated = true;
            PlaySFX();
        }
    }
    public void SetSliderValue(float value)
    {
        targetValue = value;
    }

    public void PlaySFX()
    {
        audioSource.Play();
    }
}
