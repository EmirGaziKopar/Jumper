using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileResulationForPc : MonoBehaviour
{
    static int sayac;
    private void Awake()
    {
        if (sayac < 1)
        {
            sayac++;
            //Set screen size for Standalone
            #if UNITY_STANDALONE
                Screen.SetResolution(564, 960, false);
                Screen.fullScreen = false;
            #endif
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
