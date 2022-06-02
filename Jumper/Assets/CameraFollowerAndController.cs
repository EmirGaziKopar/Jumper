using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowerAndController : MonoBehaviour
{
    float time;
    public static bool isMove;
    public Transform cameraPosition;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {       
              
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, cameraPosition.transform.position, Time.deltaTime * speed);
        //transform.position = new Vector3(transform.position.x, y, transform.position.z);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "astro")
        {
            isMove = true;
        }
    }
    
}
