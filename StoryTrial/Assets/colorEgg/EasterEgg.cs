using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class EasterEgg : MonoBehaviour
{
    public Text Message;
    public GameObject[] face;
    public bool first;
    // Start is called before the first frame update
    void Start()
    {

        Message.DOText("SHH!",1.0f);
        Invoke("TextOne", 3.0f);
        if(first == false)
        {
            for(int i = 0; i < 6; i++)
            {
                face[i].SetActive(false);
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TextOne()
    {
        Message.text = (" ");
        Message.DOText("Sorry,I can't talk too much.", 3.0f);
        Invoke("TextTwo", 5.0f);
    }

    void TextTwo()
    {
        Message.text = (" ");
        Message.DOText("They're watching.", 3.0f);
        Invoke("TextThree", 5.0f);
    }

    void TextThree()
    {
        Message.text = (" ");
        Message.DOText("Please,wait for my next message.", 3.0f);
        Invoke("TextFour", 5.0f);
    }

    void TextFour()
    {
        Message.text = (" ");
        Message.DOText("Now...     Destroy this!", 4.0f);
        Invoke("MessageOver", 10.0f);
        first = false;
    }

    void MessageOver()
    {
        TouchSound.theBGM.volume = 0.5f;
    }
}
