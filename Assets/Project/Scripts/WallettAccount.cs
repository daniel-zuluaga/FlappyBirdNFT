using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WallettAccount : MonoBehaviour
{
    public TextMeshProUGUI myAccount;

    // Start is called before the first frame update
    void Start()
    {
        myAccount.text = PlayerPrefs.GetString("Account");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
