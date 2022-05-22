using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CollectionController : MonoBehaviour
{
   
    

    public static int Coins;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //CoinsText.text = Coins.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "astro")
        {
            Coins++;
            Destroy(this.gameObject);
            Debug.Log(Coins);           
        }
    }
    
}
