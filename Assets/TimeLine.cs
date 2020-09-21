using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class TimeLine : MonoBehaviour
{
    public GameObject[] ObjectToActive;
    public int WhatObjectActive;
    
    public void SetOn()
    {
        ObjectToActive[WhatObjectActive].SetActive(true);
    }

    public void SetOff()
    {
        ObjectToActive[WhatObjectActive].SetActive(false);
    }
}