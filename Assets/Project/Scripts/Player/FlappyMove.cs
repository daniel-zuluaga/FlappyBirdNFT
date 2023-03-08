using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;
using Newtonsoft.Json;
using System;

public class FlappyMove : MonoBehaviour
{
    public static FlappyMove instanceFlappyBird;

    public float jumpForce;
    public Rigidbody2D rb;
    public GameOver gameOver;
    public AudioSource audioSource;
    public SpriteRenderer meshRenderer;
    //public Texture textureFlappy;

    private void Awake()
    {
        instanceFlappyBird = this;
    }

    //void Start()
    //{
    //    VerificationImage();
    //}

    //public void VerificationImage()
    //{
    //    ERC1155URIExample.instanceERC1155URIExample.CheckUriImage();
    //}

    private void Update()
    {
        Jump();
    }

    public void Jump()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * jumpForce;
            audioSource.Play();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Obstacle"))
        {
            gameOver.GameOverCanvas();
        }
    }

}

