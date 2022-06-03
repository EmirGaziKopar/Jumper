using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    public float time;
    public static bool degdi;
    public bool control;
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
        if (control)
        {
            if (time < 0.6f)
            {
                time += Time.deltaTime;
            }
            else
            {
                if (sayac < 1)
                {
                    rigidbody2D.bodyType = RigidbodyType2D.Dynamic;
                    //rigidbody2D.bodyType = RigidbodyType2D.Static;
                    sayac++;
                }
            }
            
        }
    }

    
    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "astro")
        {
            control = true;
            
            
            /*else
            {
                rigidbody2D.bodyType = RigidbodyType2D.Dynamic;
                rigidbody2D.simulated = true;
                

                
            }
            */
        }
        
    }
}
