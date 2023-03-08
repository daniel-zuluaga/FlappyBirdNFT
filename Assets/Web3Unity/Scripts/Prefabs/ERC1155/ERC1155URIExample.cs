using Newtonsoft.Json.Linq;
using UnityEngine;
using UnityEngine.Networking;
using Web3Unity.Scripts.Library.ETHEREUEM.EIP;

public class ERC1155URIExample : MonoBehaviour
{
    public static ERC1155URIExample instanceERC1155URIExample;

    private void Awake()
    {
        if (instanceERC1155URIExample == null)
        {
            instanceERC1155URIExample = this;
            DontDestroyOnLoad(instanceERC1155URIExample);
        }
        else if(instanceERC1155URIExample != this)
        {
            Destroy(gameObject);
        }
    }

    async public void CheckUriImage()
    {
        string contract = "0x22dc50995B5FD16f7D4D97872F929F8D3FeC2d16";
        string tokenId = "1";
        string uri = await ERC1155.URI(contract, tokenId);
        print(uri);

        Debug.Log("-------");
        Debug.Log("Uri of the image -------" + uri);
        Debug.Log("-------");

        //using (UnityWebRequest webRequest1 = UnityWebRequest.Get(uri))
        //{
        //    await webRequest1.SendWebRequest();

        //    string metadataString = webRequest1.downloadHandler.text;
        //}
        using (UnityWebRequest webRequest2 = UnityWebRequestTexture.GetTexture(uri))
        {
            await webRequest2.SendWebRequest();

            Texture texture = DownloadHandlerTexture.GetContent(webRequest2);

            //FlappyMove.instanceFlappyBird.meshRenderer.material.mainTexture = FlappyMove.instanceFlappyBird.textureFlappy;
        }
    }
}
