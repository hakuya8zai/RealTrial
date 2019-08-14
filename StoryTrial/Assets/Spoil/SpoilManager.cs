using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpoilManager : MonoBehaviour
{
    public static bool spoilKey = false;
    public static bool CanSkip = true;

    // Start is called before the first frame update
    void Start()
    {
        CanSkip = true;
        spoilKey = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(spoilKey == true)
        {
            Spoil();
        }
        else
        {
            EndManagement.spoiler.SetActive(false);
        }

        
    }


    public void SpoilTrigger()
    {
        UIManager.theCheckCanvas.SetActive(false);
        CanSkip = false;
        AdTest.Inst.AdrealTest();
        spoilKey = true;

        UIManager.UIOpen = false;
        GameManagement.OnEnable();
    }

    void Spoil()

    {
        EndManagement.spoiler.SetActive(true);
    }

}
