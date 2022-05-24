using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Can : " + JumperController.Can);

        if (JumperController.Can == 2)
        {
            transform.GetChild(0).gameObject.SetActive(false);
        }
        if (JumperController.Can == 1)
        {
            transform.GetChild(1).gameObject.SetActive(false);
        }
        if (JumperController.Can == 0)
        {
            transform.GetChild(2).gameObject.SetActive(false);
            Time.timeScale = 0f;
            //GameOver panel gelecek
        }
    }
}
