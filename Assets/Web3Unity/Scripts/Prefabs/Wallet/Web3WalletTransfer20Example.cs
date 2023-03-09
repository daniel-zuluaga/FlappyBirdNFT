using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using Web3Unity.Scripts.Library.ETHEREUEM.EIP;
using Web3Unity.Scripts.Library.Ethers.Contracts;
using Web3Unity.Scripts.Library.Web3Wallet;
using TMPro;
using UnityEngine.SceneManagement;

public class Web3WalletTransfer20Example : MonoBehaviour
{
    public string amountA;

    public TextMeshProUGUI hash;
    public string sceneName;

    async public void OnTransfer20()
    {
        // https://chainlist.org/
        string chainId = "97"; // goerli
        // contract to interact with 
        string contract = "0x703C57f7823f4e369A702Db901D9efe2da4FCF9D";
        // value in wei
        string value = "0";
        // abi in json format
        string abi = ABI.ERC_20;
        // smart contract method to call
        string method = "ERC20";//ETH_METHOD.Transfer;
        // account to send erc20 to
        string toAccount = "0x0978d44967c83E72cEEEa7ed2D021853EC29bc80";
        // amount of erc20 tokens to send
        string amount = amountA;
        // webgl 10000000000000000000
        // create data to interact with smart contract
        var contractData = new Contract(abi, contract);
        var data = contractData.Calldata(method, new object[]
        {
            toAccount,
            amount
        });
        // gas limit OPTIONAL
        string gasLimit = "";
        // gas price OPTIONAL
        string gasPrice = "";
        // send transaction
        string response = await Web3Wallet.SendTransaction(chainId, contract, value, data, gasLimit, gasPrice);
        print(response);
        hash.text = response;
    }

    public void Update()
    {
        if (hash.text.Contains("0"))
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
