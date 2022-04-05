// Copyright (c) 2014 The Chromium Authors. All rights reserved.
// Use of this source code is governed by a BSD-style license that can be
// found in the LICENSE file.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dino2 : MonoBehaviour
{
    public GameObject stand;
    public GameObject crouch;
    public GameManager gameManager;

    void Update()
    {
        if (gameManager.GameOverFlag == true)
        {
            return;
        }
        if (Input.GetKeyUp("down"))
        {
            SetStand();
        }
    }
    private void SetStand()
    {
        stand.SetActive(true);
        crouch.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collisionInfo)
    {
        if (gameManager.GameOverFlag == true)
        {
            return;
        }
        if (collisionInfo.tag == "obstacle" ||
            collisionInfo.tag == "obstacle9")
        {
            gameManager.GameOver();
        }
    }
}
