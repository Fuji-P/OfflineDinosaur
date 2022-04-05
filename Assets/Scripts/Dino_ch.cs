// Copyright (c) 2014 The Chromium Authors. All rights reserved.
// Use of this source code is governed by a BSD-style license that can be
// found in the LICENSE file.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dino_ch : MonoBehaviour
{
    public GameManager gameManager;

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
