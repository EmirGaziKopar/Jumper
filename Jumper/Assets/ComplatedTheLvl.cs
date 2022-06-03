using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ComplatedTheLvl : MonoBehaviour
{
    public int CurrentLevel;
    public Animator anim;
    public bool gecBolum;
    public float time;
    public int sayac;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gecBolum == true)
        {
            if (time < 1)
            {
                time += Time.deltaTime;
            }
            else
            {
                if (sayac < 1)
                {
                    SceneManager.LoadScene(CurrentLevel + 1, LoadSceneMode.Single);
                    sayac++;
                }               
            }
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "astro")
        {
            gecBolum = true;
            Destroy(collision.gameObject);
            anim.enabled = true;
            //SceneManager.LoadScene(CurrentLevel + 1, LoadSceneMode.Single);

        }
    }
}
