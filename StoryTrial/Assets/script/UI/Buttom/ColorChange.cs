using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChange : MonoBehaviour
{
    public Button[] selections = new Button[40];
    int progress = 1;
    public Color before;
    public Color now;
    public Color after;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        progress = PlayerPrefs.GetInt("saveLevel") - 1;

        for(int i =0;i<progress;i++)
        {
            ColorBlock a = selections[i].colors;
            a.normalColor = before;
            selections[i].colors = a;
        }

        ColorBlock c = selections[progress].colors;
        c.normalColor = now;
        selections[progress].colors = c;

        for(int k = 39; k >progress; k--)
        {
            ColorBlock b = selections[k].colors;
            b.normalColor = after;
            selections[k].colors = b;
        }

        
    }
}
