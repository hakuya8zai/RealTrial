using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchSound : MonoBehaviour
{
    public AudioSource beatOne;
    public AudioSource beatTwo;
    private bool One = true;
    public static bool playAudio = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(playAudio == true)
        {
            playAudio = false;
            AudioPlay();
        }
        
    }

    void AudioPlay()
    {
        if(One== true)
        {
            beatOne.Play();
            One = false;

        }
        else if (One == false)
        {
            beatTwo.Play();
            One = true;

        }

    }
}
