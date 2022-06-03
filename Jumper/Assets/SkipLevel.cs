using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SkipLevel : MonoBehaviour
{
    
    public int CurrentLevel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void nextLvl()
    {
        SceneManager.LoadScene(CurrentLevel + 1, LoadSceneMode.Single);
    }
}
