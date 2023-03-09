using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTubo : MonoBehaviour
{
    public float speed;
    public float points;
    public AudioSource WinPoint;

    void FixedUpdate()
    {
        Move();

        speed += 0.1f * Time.deltaTime;

        Destroy(gameObject, 10f);
    }

    public void Move()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        WinPoints.instancePoints.PlusPoints(points);
        WinPoint.playOnAwake = false;
        WinPoint.Play();
    }
}
