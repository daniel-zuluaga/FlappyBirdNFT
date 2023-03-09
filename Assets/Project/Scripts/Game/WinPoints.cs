using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class WinPoints : MonoBehaviour
{
    public TextMeshProUGUI pointsPlayer;

    public static WinPoints instancePoints;

    private void Awake()
    {
        instancePoints = this;
    }

    public float points;

    private void Start()
    {
        points = 0;
    }

    private void Update()
    {
        pointsPlayer.text = ": " + points.ToString();
    }

    public void PlusPoints(float pointsPlus)
    {
        points += pointsPlus;
    }
}
