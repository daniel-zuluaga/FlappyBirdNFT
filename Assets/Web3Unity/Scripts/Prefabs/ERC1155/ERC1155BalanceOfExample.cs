using System.Numerics;
using UnityEngine;
using Web3Unity.Scripts.Library.ETHEREUEM.EIP;

public class ERC1155BalanceOfExample : MonoBehaviour
{
    public GameObject flappyGreen;

    async public void CheckNFT()
    {
        string contract = "0x703C57f7823f4e369A702Db901D9efe2da4FCF9D";
        string account = PlayerPrefs.GetString("Account");
        string tokenId = "4";

        BigInteger balanceOf = await ERC1155.BalanceOf(contract, account, tokenId);
        print(balanceOf);

        if (balanceOf > 0)
        {
            flappyGreen.SetActive(true);
        }
    }
}
