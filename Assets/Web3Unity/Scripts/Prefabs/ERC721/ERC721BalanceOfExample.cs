using System.Numerics;
using UnityEngine;
using Web3Unity.Scripts.Library.ETHEREUEM.EIP;
using UnityEngine.SceneManagement;

public class ERC721BalanceOfExample : MonoBehaviour
{
    async void CheckNFTRefinable()
    {
        string contract = "0x9123541E259125657F03D7AD2A7D1a8Ec79375BA";
        string account = PlayerPrefs.GetString("Account");

        BigInteger balance = await ERC721.BalanceOf(contract, account);
        print(balance);
    }

    public void NFTRefinableScene()
    {
        SceneManager.LoadScene("GameRefinable");
    }
}
