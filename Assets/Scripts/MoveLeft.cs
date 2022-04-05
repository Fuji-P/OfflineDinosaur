// Copyright (c) 2014 The Chromium Authors. All rights reserved.
// Use of this source code is governed by a BSD-style license that can be
// found in the LICENSE file.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed;
    public float start;
    public float end;
    public GameManager gameManager;
    // Update is called once per frame
    void Update()
    {
        if (gameManager.GameOverFlag == true)
        {
            return;
        }
        transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
        if (transform.position.x <= end)
        {
            transform.position = new Vector2(start, transform.position.y);
        }
    }
}
