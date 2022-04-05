// Copyright (c) 2014 The Chromium Authors. All rights reserved.
// Use of this source code is governed by a BSD-style license that can be
// found in the LICENSE file.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft_Obstacle : MonoBehaviour
{
    private float speed = 16.0f;
    private float start_x;
    private float start_y;
    private float end = -20;
    private bool first = true;
    private GameManager gameManager;
    Animator obstacleAnimaor;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        if (gameObject.tag == "obstacle9")
        {
            obstacleAnimaor = GetComponent<Animator>();
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (gameManager.GameOverFlag == true)
        {
            if (gameObject.tag == "obstacle9")
            {
                obstacleAnimaor.enabled = false;
            }
            return;
        }

        start_x = 0;
        start_y = 0;

        if (first == true)
        {
            SetStartPos();
            first = false;
        }

        transform.position = new Vector2(transform.position.x + start_x - speed * Time.deltaTime, transform.position.y + start_y);

        if (transform.position.x <= end)
        {
            Destroy(gameObject);
            first = true;
        }
    }
    private void SetStartPos()
    {
        if (gameObject.tag == "obstacle9")
        {
            start_x = Random.Range(-2, 3);
            start_y = Random.Range(-1, 2);
        }
        else
        {
            start_x = Random.Range(-2, 3);
        }
    }
}
