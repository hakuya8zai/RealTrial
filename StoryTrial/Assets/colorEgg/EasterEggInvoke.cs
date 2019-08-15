using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasterEggInvoke : MonoBehaviour
{
    public GameObject EasterEgg;
    private bool yes = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.CompareTag("filled"))
        {
            if (yes == false)
            {
                TouchSound.theBGM.volume = 0.0f;
                yes = true;
                EasterEgg.SetActive(true);

            }

        }
        
    }
}
