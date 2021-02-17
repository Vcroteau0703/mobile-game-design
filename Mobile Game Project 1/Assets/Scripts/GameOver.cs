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
    private SpawnPickups spawnPickups;

    private void Awake()
    {
        moveByTouch = player.GetComponent<MoveByTouch>();
        spawnPickups = GetComponent<SpawnPickups>();
    }

    // Update is called once per frame
    void Update()
    {
        if(waterSlider.value == 100 || waterSlider.value == 0 || sunSlider.value == 100 || sunSlider.value == 0)
        {
            Pause();
        }

    }

    void Pause()
    {
        gameOver.SetActive(true);
        moveByTouch.enabled = false;
        spawnPickups.enabled = false;
    }

    void UnPause()
    {
        moveByTouch.enabled = true;
        spawnPickups.enabled = true;
        gameOver.SetActive(false);
    }

    public void Restart()
    {

        SceneManager.LoadScene(0);
        UnPause();
    }
}
