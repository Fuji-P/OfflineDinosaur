// Copyright (c) 2014 The Chromium Authors. All rights reserved.
// Use of this source code is governed by a BSD-style license that can be
// found in the LICENSE file.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject GOPanel;
    public GameObject Dino;
    public GameObject Dino2;
    public GameObject DinoGO;
    AudioSource gameoverSE;
    private static bool _GameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        gameoverSE = GetComponent<AudioSource>();
        GameOverFlag = false;
    }
    public void GameOver()
    {
        if (GameOverFlag == true)
        {
            return;
        }
        GameOverFlag = true;
        gameoverSE.Play();
        SetDinoGO();
//        Time.timeScale = 0;
    }

    private void SetDinoGO()
    {
        Vector3 DinoPos = Dino.transform.position;
        DinoGO.transform.position = DinoPos;
        Dino.SetActive(false);
        Dino2.SetActive(false);
        DinoGO.SetActive(true);
        GOPanel.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Game");
    }

    public bool GameOverFlag
    {
        set
        {
            _GameOver = value;
        }
        get
        {
            return _GameOver;
        }
    }
}
