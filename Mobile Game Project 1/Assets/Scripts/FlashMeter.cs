using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlashMeter : MonoBehaviour
{
    Slider slider;
    AudioSource audioSource;
    Animator animator;

    bool isFlashing = false;

    private void Awake()
    {
        slider = GetComponent<Slider>();
        animator = transform.GetChild(1).GetChild(0).GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if(slider.value < 15 || slider.value > 85)
        {
            if (!isFlashing)
            {
                animator.SetTrigger("Flash");
                if (slider.value > 85)
                {
                    audioSource.Play();
                }
                isFlashing = true;
            }
        }
        else if(slider.value > 15 || slider.value < 85)
        {
            if (isFlashing)
            {
                animator.SetTrigger("StopFlash");
                isFlashing = false;
            }
        }
    }

}
