using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinsController : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        CollectionController.Coins = 0;
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.GetComponent<TextMeshProUGUI>().text = "Coins : " + CollectionController.Coins;
    }
}
