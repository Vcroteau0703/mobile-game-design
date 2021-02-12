using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUp : MonoBehaviour
{
    public Slider waterSlider;
    public Slider sunSlider;
    public float targetTime = 5f;
    //public float waterValue;
    //public float sunValue;

    private void Awake()
    {
        waterValue = waterSlider.value; 
        sunValue = sunSlider.value;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "water")
        {
            waterSlider.value += 20;
            sunSlider.value -= 5;
            Destroy(collision);
        }
        else if (collision.tag == "sunlight")
        {
            sunSlider.value += 20;
            waterSlider.value -= 5;
            Destroy(collision);
        }
    }

    private void Update()
    {
        targetTime -= Time.deltaTime;
        if(targetTime <= 0.0f)
        {
            sunSlider.value -= 1;
            waterSlider.value -= 1;
            targetTime = 1f;
        }
    }


}
