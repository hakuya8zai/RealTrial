using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class FloatEffect : MonoBehaviour
{
    bool one = true;
    // Start is called before the first frame update
    void Start()
    {
        On();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void On()
    {
        transform.DOLocalMove(new Vector3(0, -350, 0), 1.0f);
        Invoke(("Off"), 1.0f);
    }
    public void Off()
    {
        transform.DOLocalMove(new Vector3(0, -390, 0), 1.5f);
        Invoke(("On"), 1.5f);
    }
}
