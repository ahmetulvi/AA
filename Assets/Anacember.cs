using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anacember : MonoBehaviour
{
    public GameObject kucukCember;
    GameObject OyunYonetici;
    void Start()
    {
        OyunYonetici = GameObject.FindWithTag("oyunyoneticitag");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            kucukCemberOlustur();
        }
    }
    void kucukCemberOlustur()
    {
        Instantiate(kucukCember, transform.position, transform.rotation);
        OyunYonetici.GetComponent<OyunYoneticisi>().KucukCemberlerdeText();
    }
}
