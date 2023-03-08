using System.Collections.Generic;
using System.Numerics;
using System.Threading.Tasks;
using UnityEngine;
using TMPro;
using Web3Unity.Scripts.Library.ETHEREUEM.EIP;
using UnityEngine.SceneManagement;

public class ERC1155BalanceOfExample : MonoBehaviour
{
    public GameObject flappyGreen;
    public TextMeshProUGUI notNFTText;

    async public void CheckNFT()
    {
        string contract = "0x22dc50995B5FD16f7D4D97872F929F8D3FeC2d16";
        string account = PlayerPrefs.GetString("Account");
        string tokenId = "1";

        BigInteger balanceOf = await ERC1155.BalanceOf(contract, account, tokenId);
        print(balanceOf);

        if (balanceOf > 0)
        {
            notNFTText.text = "";
            SceneManager.LoadScene("GameOpenSea");
        }
        else if(balanceOf <= 0)
        {
            notNFTText.text = "No hay NFT en esta cuenta";
        }
    }
}
