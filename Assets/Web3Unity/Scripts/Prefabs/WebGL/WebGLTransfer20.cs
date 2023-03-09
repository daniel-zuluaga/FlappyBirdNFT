using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using Newtonsoft.Json;
using Web3Unity.Scripts.Library.ETHEREUEM.EIP;
using Web3Unity.Scripts.Prefabs;

public class WebGLTransfer20 : MonoBehaviour
{
    [SerializeField]
    private string contract = "0x703C57f7823f4e369A702Db901D9efe2da4FCF9D";
    private string toAccount = PlayerPrefs.GetString("Account");
    private string toAccount1 = "0x0978d44967c83E72cEEEa7ed2D021853EC29bc80";
    [SerializeField]
    private string amount = "50000000000000000";

    private readonly string abi = ABI.ERC_20;

    public TextMeshProUGUI hash;

    async public void Transfer()
    {
        // smart contract method to call
        string method = "transfer";
        // array of arguments for contract
        string[] obj = { toAccount1, amount };
        string args = JsonConvert.SerializeObject(obj);
        // value in wei
        string value = "0";
        // gas limit OPTIONAL
        string gasLimit = "";
        // gas price OPTIONAL
        string gasPrice = "";
        // connects to user's browser wallet (metamask) to send a transaction
        try
        {
            string response = await Web3GL.SendContract(method, abi, contract, args, value, gasLimit, gasPrice);
            Debug.Log(response);
            hash.text = response;
        }
        catch (Exception e)
        {
            Debug.LogException(e, this);
        }
    }

    async public void SendTransaction()
    {
        // smart contract method to call
        string method = "transfer";
        // array of arguments for contract
        string[] obj = { toAccount, amount };
        string args = JsonConvert.SerializeObject(obj);
        // value in wei
        string value = "0";
        // gas limit OPTIONAL
        string gasLimit = "";
        // gas price OPTIONAL
        string gasPrice = "";
        // connects to user's browser wallet (metamask) to send a transaction
        try
        {
            string response = await Web3GL.SendContract(method, abi, contract, args, value, gasLimit, gasPrice);
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
            SceneManager.LoadScene("Game");
        }
    }
}