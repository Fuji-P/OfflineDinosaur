// Copyright (c) 2014 The Chromium Authors. All rights reserved.
// Use of this source code is governed by a BSD-style license that can be
// found in the LICENSE file.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dino : MonoBehaviour
{
    public GameObject stand;
    public GameObject crouch;
    public GameManager gameManager;
    AudioSource jumpSE;
    Rigidbody2D rb;
    int jumpForce = 40;
    bool isJumping = false;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        isJumping = false;
        rb = GetComponent<Rigidbody2D>();
        jumpSE = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.GameOverFlag == true ||
            isJumping == true)
        {
            return;
        }
        if (Input.GetKey("space"))
        {
            Jump();
        }
        if (Input.GetKey("down"))
        {
            SetCrouch();
        }
    }

    private void Jump()
    {
        jumpSE.Play();
        rb.velocity = new Vector3(0, jumpForce, 0);
        isJumping = true;
        animator.SetBool("onGround", isJumping);
    }

    private void SetCrouch()
    {
        crouch.SetActive(true);
        stand.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        isJumping = false;
        animator.SetBool("onGround", isJumping);
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
