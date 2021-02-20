using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AddScore : MonoBehaviour
{
    public float time = 1f;
    TextMeshProUGUI scoreUI;
    public int score;

    private void Start()
    {
        scoreUI = GetComponent<TextMeshProUGUI>();
        score = 0;
        scoreUI.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        if(time <= 0.0f)
        {
            UpdateScore();
        }
    }

    void UpdateScore()
    {
        score += 10;
        scoreUI.text = score.ToString();
        time = 1f;
    }
}
