using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTubo : MonoBehaviour
{
    public float speed;

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
}
