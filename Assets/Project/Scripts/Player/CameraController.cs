using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    public float offsetPlayer;

    private void Update()
    {
        transform.position = new Vector2(player.transform.position.x + offsetPlayer, transform.position.y);
    }
}
