using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class texturetill : MonoBehaviour
{

    public Renderer rend;
    void Start()
    {
        rend = GetComponent<Renderer>();
    }
    void Update()
    {
        float scaleX = Mathf.Cos(Time.time) * 0.5F + 1;
        float scaleY = Mathf.Sin(Time.time) * 0.5F + 1;
        rend.material.mainTextureScale = new Vector2(scaleX, scaleY);
    }
}
