using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumperController : MonoBehaviour
{
    public static float Can;
    float time2;
    float time;

    public GameObject BloodyEffect;

    public Animator anim;


    public float jump = 4f;

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        Can = 3;
    }

    // Update is called once per frame
    void Update()
    {
        //this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(1*Time.deltaTime, 0, 0);
        
        //time2 += Time.deltaTime;
        Debug.Log(time2);

        if (time < 0.2f)
        {

            time += Time.deltaTime; 
            
        }
        else
        {
            
            BloodyEffect.SetActive(false);
        }

    }
    private void FixedUpdate()
    {
        transform.position += new Vector3(0, jump * Time.deltaTime, 0);

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //enemy ziplatan enemy'dir
        if(collision.gameObject.tag == "enemy")
        {

            Can--;
            BloodyEffect.SetActive(true);
            time = 0;
            this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(-8,8), 0, 0);
        }

        if(collision.gameObject.tag == "floor")
        {
            anim.SetTrigger("jump");
        }

        if (collision.gameObject.tag == "trambolin")
        {
            Debug.Log("girdik mi ?");
            anim.SetTrigger("jump");
            jump *= 1.5f;
        }

    }
}
