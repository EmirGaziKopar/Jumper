using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverController : MonoBehaviour
{
    public Image GameOverPanel;
    // Start is called before the first frame update
    void Start()
    {
        GameOverPanel.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(JumperController.Can == 0)
        {
            GameOverPanel.gameObject.SetActive(true);
        }
        
    }
}
