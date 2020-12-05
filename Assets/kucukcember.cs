using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kucukcember : MonoBehaviour
{
    Rigidbody2D fizik;
    public float hız;
    bool hareketkontrol = false;
    GameObject oyunYoneticisi;

    void Start()
    {
        fizik = GetComponent<Rigidbody2D>();
        oyunYoneticisi = GameObject.FindWithTag("oyunyoneticitag");

    }

    void FixedUpdate()
    {
        if (!hareketkontrol)
        {
            fizik.MovePosition(fizik.position + Vector2.up * hız * Time.deltaTime);

        }
    }
     void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag=="donencemtag")
        {
            transform.SetParent(collision.transform);
            hareketkontrol = true;
        }
        if (collision.tag=="kucukcembertag")
        {

            oyunYoneticisi.GetComponent<OyunYoneticisi>().OyunBitti();
        }
    }
}
