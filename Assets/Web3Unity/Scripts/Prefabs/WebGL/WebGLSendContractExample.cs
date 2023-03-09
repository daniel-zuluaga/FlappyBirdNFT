using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;
using TMPro;
using UnityEngine.SceneManagement;

#if UNITY_WEBGL
public class WebGLSendContractExample : MonoBehaviour
{
    public TextMeshProUGUI confirmation;

    async public void OnSendContract()
    {
        // smart contract method to call
        string method = "addTotal";
        // abi in json format
        string abi = "[ { \"inputs\": [ { \"internalType\": \"uint8\", \"name\": \"_myArg\", \"type\": \"uint8\" } ], \"name\": \"addTotal\", \"outputs\": [], \"stateMutability\": \"nonpayable\", \"type\": \"function\" }, { \"inputs\": [], \"name\": \"myTotal\", \"outputs\": [ { \"internalType\": \"uint256\", \"name\": \"\", \"type\": \"uint256\" } ], \"stateMutability\": \"view\", \"type\": \"function\" } ]";
        // address of contract
        string contract = "0x8EeB70dA78629613b16Fe9f01a4DEbab98970129";
        // array of arguments for contract
        string args = "[\"1\"]";
        // value in wei
        string value = "0";
        // gas limit OPTIONAL
        string gasLimit = "";
        // gas price OPTIONAL
        string gasPrice = "";
        // connects to user's browser wallet (metamask) to update contract state
        try
        {
            string response = await Web3GL.SendContract(method, abi, contract, args, value, gasLimit, gasPrice);
            Debug.Log(response);
            confirmation.text = response;
        }
        catch (Exception e)
        {
            Debug.LogException(e, this);
        }
    }

    private void Update()
    {
        if (confirmation.text.Contains("0"))
        {
            SceneManager.LoadScene("Win");
        }
    }
}
#endif
