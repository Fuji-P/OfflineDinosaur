// Copyright (c) 2014 The Chromium Authors. All rights reserved.
// Use of this source code is governed by a BSD-style license that can be
// found in the LICENSE file.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreImg : MonoBehaviour
{
    public ImageNo HIScoreImageNo;
    public ImageNo ScoreImageNo;
    public GameObject ScoreImage;
    int score;
    float timer;
    float maxTime;
    AudioSource scoreSE;
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        HIScoreImageNo.SetNo(PlayerPrefs.GetInt("highscore", 0), "00000");
        score = 0;
        ScoreImageNo.SetNo(score, "00000");
        maxTime = 0.1f;
        scoreSE = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.GameOverFlag == true)
        {
            HighScore();
            return;
        }
        timer += Time.deltaTime;
        if (timer >= maxTime)
        {
            Score();
        }

//        if(Time.timeScale == 0)
//        {
//            if (score > PlayerPrefs.GetInt("highscore", 0))
//            {
//                PlayerPrefs.SetInt("highscore", score);
//                HIScoreImageNo.SetNo(PlayerPrefs.GetInt("highscore", 0), "00000");
//            }
//        }
    }

    private void HighScore()
    {
        if (score > PlayerPrefs.GetInt("highscore", 0))
        {
            PlayerPrefs.SetInt("highscore", score);
            HIScoreImageNo.SetNo(PlayerPrefs.GetInt("highscore", 0), "00000");
        }
    }
    private void Score()
    {
        score++;
        ScoreImageNo.SetNo(score, "00000");
        timer = 0;
        if (score % 100 == 0)
        {
            FlashScore100();
        }
    }

    private void FlashScore100()
    {
        scoreSE.Play();
        Time.timeScale += 0.15f;
    }
}
