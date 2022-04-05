// Copyright (c) 2014 The Chromium Authors. All rights reserved.
// Use of this source code is governed by a BSD-style license that can be
// found in the LICENSE file.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
    public GameObject StartText;
    Rigidbody2D rb;
    int jumpForce = 40;
    bool isJumping = false;
    // Start is called before the first frame update
    void Start()
    {
        isJumping = false;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isJumping == true)
        {
            return;
        }
        if (Input.GetKey("space"))
        {
            StartText.SetActive(true);
            Jump();
        }
    }
    private void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (isJumping == true)
        {
            SceneManager.LoadScene("Game");
        }
    }

    private void Jump()
    {
        rb.velocity = new Vector3(0, jumpForce, 0);
        isJumping = true;
    }
}
