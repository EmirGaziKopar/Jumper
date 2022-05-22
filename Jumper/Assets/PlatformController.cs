using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    public static bool degdi;
    //public GameObject gameObject;
    int sayac;
    new Rigidbody2D rigidbody2D;
    // Start is called before the first frame update
    void Start()
    {
        degdi = false;
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //rigidbody2D.simulated = true;
    }

    
    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "astro")
        {
            if (sayac < 1)
            {
                rigidbody2D.bodyType = RigidbodyType2D.Static;
                sayac++;
            }
            else
            {
                rigidbody2D.bodyType = RigidbodyType2D.Dynamic;
                rigidbody2D.simulated = true;
                

                degdi = true;
            }
        }
        
    }
}
