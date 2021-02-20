using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlashMeter : MonoBehaviour
{
    Slider slider;

    Animator animator;

    private void Awake()
    {
        slider = GetComponent<Slider>();
        animator = transform.GetChild(1).GetChild(0).GetComponent<Animator>();
    }

    private void Update()
    {
        if(slider.value < 15 || slider.value > 85)
        {
            animator.SetTrigger("Flash");
        }
        else if(slider.value > 15 || slider.value < 85)
        {
            animator.SetTrigger("StopFlash");
        }
    }

}
