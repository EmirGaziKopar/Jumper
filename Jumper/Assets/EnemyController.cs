using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    //Düsman öldürme kodu
    bool killed;

    float dusus = -5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (killed)
        {
            dusus -= 0.05f;
            transform.position += new Vector3(0, dusus*Time.deltaTime, 0);
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        killed = true;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
}
