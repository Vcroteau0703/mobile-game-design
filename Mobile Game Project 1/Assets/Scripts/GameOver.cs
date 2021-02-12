using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject player;
    public MoveByTouch moveByTouch;
    public Slider waterSlider;
    public Slider sunSlider;
    public GameObject gameOver;

    private void Awake()
    {
        moveByTouch = player.GetComponent<MoveByTouch>();
    }

    // Update is called once per frame
    void Update()
    {
        if(waterSlider.value == 100 || waterSlider.value == 0)
        {
            Time.timeScale = 0;
            gameOver.SetActive(true);
            moveByTouch.enabled = false;
        }
        if (sunSlider.value == 100 || sunSlider.value == 0)
        {
            Time.timeScale = 0;
            gameOver.SetActive(true);
            moveByTouch.enabled = false;
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
