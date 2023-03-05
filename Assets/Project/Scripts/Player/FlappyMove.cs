using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlappyMove : MonoBehaviour
{
    public float jumpForce;
    private Rigidbody2D rb;
    public GameOver gameOver;
    public AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

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

