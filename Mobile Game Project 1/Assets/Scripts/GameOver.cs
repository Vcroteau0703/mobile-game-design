using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject player;
    private MoveByTouch moveByTouch;
    public Slider waterSlider;
    public Slider sunSlider;
    public GameObject gameOver;
    public GameObject score;
    private AddScore addScore;
    private SpawnPickups spawnPickups;
    private PickUp pickUp;

    private void Awake()
    {
        moveByTouch = player.GetComponent<MoveByTouch>();
        pickUp = player.GetComponent<PickUp>();
        spawnPickups = GetComponent<SpawnPickups>();
        addScore = score.GetComponent<AddScore>();
    }

    // Update is called once per frame
    void Update()
    {
        if(waterSlider.value == 100 || waterSlider.value == 0 || sunSlider.value == 100 || sunSlider.value == 0 || pickUp.insectCount == 2)
        {
            Pause();
        }

    }

    void Pause()
    {
        gameOver.SetActive(true);
        spawnPickups.gameActive = false;
        StopCoroutine(spawnPickups.StartSpawning());
        moveByTouch.gameActive = false;
        pickUp.enabled = false;
        addScore.enabled = false;
    }

    //void UnPause()
    //{
    //    moveByTouch.enabled = true;
    //    spawnPickups.enabled = true;
    //    gameOver.SetActive(false);
    //}

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
