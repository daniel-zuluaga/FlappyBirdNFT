using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnHome : MonoBehaviour
{
    public void ReturnHomeGame()
    {
        GameManager.instanceGameManager.HomeGame();
    }
}
