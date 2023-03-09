using System.Numerics;
using UnityEngine;
using Web3Unity.Scripts.Library.ETHEREUEM.EIP;

public class ERC20BalanceOfExample : MonoBehaviour
{
    async public void BalanceOf()
    {
        string contract = "0x703c57f7823f4e369a702db901d9efe2da4fcf9d";
        string account = "0x0978d44967c83E72cEEEa7ed2D021853EC29bc80";

        BigInteger balanceOf = await ERC20.BalanceOf(contract, account);
        Debug.Log("Balance Of: " + balanceOf);
    }
}
