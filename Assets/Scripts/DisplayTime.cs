using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class DisplayTime : MonoBehaviour
{
    public TMP_Text textTimer;

    // Update is called once per frame
    void Update()
    {
        //textTimer.text = System.DateTime.Now.ToString("HH:mm:ss");
        textTimer.text = System.DateTime.Now.ToString("HH:mm");
    }
}
