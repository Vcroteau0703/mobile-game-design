using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUp : MonoBehaviour
{
    public float fillSpeed = 1f;
    public Slider waterSlider;
    public Slider sunSlider;
    public float targetTime = 5f;
    public float waterValue;
    public float sunValue;
    public float curWaterVal;
    public float curSunVal;
    public GameObject swarmingInsect;
    public int insectCount = 0;
    AudioSource[] audioSources;
    AudioSource waterSFX;
    AudioSource sunlightSFX;
    AudioSource insectSFX;

    private void Awake()
    {
        waterValue = curWaterVal = waterSlider.value; 
        sunValue = curSunVal = sunSlider.value;
        audioSources = GetComponents<AudioSource>();
        waterSFX = audioSources[0];
        sunlightSFX = audioSources[1];
        insectSFX = audioSources[2];

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "water")
        {
            waterValue += 20;
            sunValue -= 5;
            waterSFX.Play();
            Destroy(collision.gameObject);
        }
        else if (collision.tag == "sunlight")
        {
            sunValue += 20;
            waterValue -= 5;
            sunlightSFX.Play();
            Destroy(collision.gameObject);
        }
        else if (collision.tag == "insect")
        {
            waterValue -= 10;
            sunValue -= 10;
            insectSFX.Play();
            Destroy(collision.gameObject);
            Instantiate(swarmingInsect, transform, false);
            insectCount++;
        }
    }

    private void Update()
    {
        targetTime -= Time.deltaTime;
        if(targetTime <= 0.0f)
        {
            sunValue -= 5;
            waterValue -= 5;
            targetTime = 1f;
        }
        curWaterVal = Mathf.Lerp(curWaterVal, waterValue, Time.deltaTime * fillSpeed);
        curSunVal = Mathf.Lerp(curSunVal, sunValue, Time.deltaTime * fillSpeed);

        waterSlider.value = curWaterVal;
        sunSlider.value = curSunVal;
    }


}
