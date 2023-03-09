using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using Web3Unity.Scripts.Library.Web3Wallet;

public class Web3WalletSendTransactionExample : MonoBehaviour
{
    public TextMeshProUGUI confirmation;
    public string nameScene;

    async public void OnSendTransaction()
    {
        // https://chainlist.org/
        string chainId = "97"; // goerli
        // account to send to
        string to = PlayerPrefs.GetString("Account");
        // value in wei
        string value = "1230000000000";
        // data OPTIONAL
        string data = "";
        // gas limit OPTIONAL
        string gasLimit = "";
        // gas price OPTIONAL
        string gasPrice = "";
        // send transaction
        string response = await Web3Wallet.SendTransaction(chainId, to, value, data, gasLimit, gasPrice);
        print(response);
        confirmation.text = response;
    }

    public void Update()
    {
        if (confirmation.text.Contains("0"))
        {
            SceneManager.LoadScene(nameScene);
        }
    }

    //async public void OnSendContract()
    //{
    //    string chainId = "97";

    //    string method = "addTotal";
    //    string contract = "0x8EeB70dA78629613b16Fe9f01a4DEbab98970129";

    //    string abi = "[ { \"inputs\": [ { \"internalType\": \"uint8\", \"name\": \"_myArg\", \"type\": \"uint8\" } ], \"name\": \"addTotal\", \"outputs\": [], \"stateMutability\": \"nonpayable\", \"type\": \"function\" }, { \"inputs\": [], \"name\": \"myTotal\", \"outputs\": [ { \"internalType\": \"uint256\", \"name\": \"\", \"type\": \"uint256\" } ], \"stateMutability\": \"view\", \"type\": \"function\" } ]";

    //    // array of arguments for contract
    //    string args = "[\"1\"]";
    //    // value in wei
    //    string value = "0";
    //    // gas limit OPTIONAL
    //    string gasLimit = "";
    //    // gas price OPTIONAL
    //    string gasPrice = "";

    //    string response = await Web3GL.SendContract(method, abi, contract, args, value, gasLimit, gasPrice);

    //    Debug.Log(response);
    //    confirmation.text = response;
    //}

    //0x8EeB70dA78629613b16Fe9f01a4DEbab98970129
}
