// Copyright (c) 2014 The Chromium Authors. All rights reserved.
// Use of this source code is governed by a BSD-style license that can be
// found in the LICENSE file.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    float maxTime;
    float timer;
    public GameObject obstacle1;
    public GameObject obstacle2;
    public GameObject obstacle3;
    public GameObject obstacle4;
    public GameObject obstacle5;
    public GameObject obstacle6;
    public GameObject obstacle7;
    public GameObject obstacle8;
    public GameObject obstacle9;
    int chooseObstacle;
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        maxTime = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.GameOverFlag == true)
        {
            return;
        }
        timer += Time.deltaTime;
        if (timer >= maxTime)
        {
            GenerateObstacle();
            timer = 0;
        }
    }

    void GenerateObstacle()
    {
        chooseObstacle = Random.Range(1, 10);
        if (chooseObstacle == 1) { GameObject newObstacle = Instantiate(obstacle1); }
        if (chooseObstacle == 2) { GameObject newObstacle = Instantiate(obstacle2); }
        if (chooseObstacle == 3) { GameObject newObstacle = Instantiate(obstacle3); }
        if (chooseObstacle == 4) { GameObject newObstacle = Instantiate(obstacle4); }
        if (chooseObstacle == 5) { GameObject newObstacle = Instantiate(obstacle5); }
        if (chooseObstacle == 6) { GameObject newObstacle = Instantiate(obstacle6); }
        if (chooseObstacle == 7) { GameObject newObstacle = Instantiate(obstacle7); }
        if (chooseObstacle == 8) { GameObject newObstacle = Instantiate(obstacle8); }
        if (chooseObstacle == 9) { GameObject newObstacle = Instantiate(obstacle9); }
    }
}
