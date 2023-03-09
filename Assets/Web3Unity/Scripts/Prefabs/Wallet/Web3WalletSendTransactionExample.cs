using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using Web3Unity.Scripts.Library.Web3Wallet;

public class Web3WalletSendTransactionExample : MonoBehaviour
{
    public TextMeshProUGUI hash;
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
        hash.text = response;
    }

    public void Update()
    {
        if (hash.text.Contains("0"))
        {
            SceneManager.LoadScene(nameScene);
        }
    }
}
