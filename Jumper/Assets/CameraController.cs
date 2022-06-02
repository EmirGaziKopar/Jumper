using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    float time;
    public Transform characterPosition;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (CameraFollowerAndController.isMove)
        {
            if (time < 0.5)
            {
                time += Time.deltaTime;
                transform.position = Vector3.MoveTowards(transform.position, characterPosition.transform.position, Time.deltaTime * 50);
                transform.position = new Vector3(0, transform.position.y, -10);
            }
            else
            {
                CameraFollowerAndController.isMove = false;
                time = 0;

            }
        }
    }

    private void FixedUpdate()
    {
        transform.position += new Vector3(0, 1 * Time.deltaTime, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "astro")
        {
            //show game over screen
            Time.timeScale = 0f;
            
            
        }
    }


}
