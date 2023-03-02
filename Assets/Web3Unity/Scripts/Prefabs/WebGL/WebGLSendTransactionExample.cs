using TMPro;
using System;
using System.Linq;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class WebGLSendTransactionExample : MonoBehaviour
{
    public TextMeshProUGUI hash;

    async public void OnSendTransaction()
    {
        // account to send to
        string to = "0x0978d44967c83E72cEEEa7ed2D021853EC29bc80";
        // amount in wei to send
        string value = "10000000000000000";
        // gas limit OPTIONAL
        string gasLimit = "";
        // gas price OPTIONAL
        string gasPrice = "";
        // connects to user's browser wallet (metamask) to send a transaction
        try
        {
            string response = await Web3GL.SendTransaction(to, value, gasLimit, gasPrice);
            Debug.Log(response);
            hash.text = response;
        }
        catch (Exception e)
        {
            Debug.LogException(e, this);
        }
    }

    public void Update()
    {
        if (hash.text.Contains("0"))
        {
            SceneManager.LoadScene(2);
        }
    }
}