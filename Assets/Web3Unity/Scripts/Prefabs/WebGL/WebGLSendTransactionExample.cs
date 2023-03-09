using TMPro;
using System;
using System.Linq;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

#if UNITY_WEBGL
public class WebGLSendTransactionExample : MonoBehaviour
{
    public TextMeshProUGUI hash;
    public string nameScene;

    async public void OnSendTransaction()
    {
        // account to send to
        string to = PlayerPrefs.GetString("Account");
        // amount in wei to send
        string value = "1000000000000000000";
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
            SceneManager.LoadScene(nameScene);
        }
    }
}
#endif