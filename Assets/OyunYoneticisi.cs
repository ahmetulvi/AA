using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OyunYoneticisi : MonoBehaviour
{

    GameObject donenCember;
    GameObject anaCember;
    public Animator animator;
    public Text DonencemberLevel;
    public Text bir;
    public Text iki;
    public Text uc;
    public int kactaneKucukCemberOlsun;
    bool kontrol = true;


    void Start()
    {
        PlayerPrefs.SetInt("kayıt",int.Parse(SceneManager.GetActiveScene().name));

        donenCember = GameObject.FindWithTag("donencemtag");
        anaCember = GameObject.FindWithTag("anacembertag");
        DonencemberLevel.text = SceneManager.GetActiveScene().name;
        if (kactaneKucukCemberOlsun<2)
        {
            bir.text = kactaneKucukCemberOlsun + "";

        }
        else if (kactaneKucukCemberOlsun<3)
        {
            bir.text = kactaneKucukCemberOlsun + "";
            iki.text=(kactaneKucukCemberOlsun-1)+"";

        }
        else
        {
            bir.text = kactaneKucukCemberOlsun + "";
            iki.text = (kactaneKucukCemberOlsun - 1) + "";
            uc.text = (kactaneKucukCemberOlsun - 2) + "";        }
    }
    public void KucukCemberlerdeText()
    {
        kactaneKucukCemberOlsun--;  
        if (kactaneKucukCemberOlsun < 2)
        {
            bir.text = kactaneKucukCemberOlsun + "";
            iki.text = "";  
            uc.text = "";

        }
        else if (kactaneKucukCemberOlsun < 3)
        {
            bir.text = kactaneKucukCemberOlsun + "";
            iki.text = (kactaneKucukCemberOlsun - 1) + "";
            uc.text = "";

        }
        else
        {
            bir.text = kactaneKucukCemberOlsun + "";
            iki.text = (kactaneKucukCemberOlsun - 1) + "";
            uc.text = (kactaneKucukCemberOlsun - 2) + "";
        }
        if (kactaneKucukCemberOlsun==0)
        {
           StartCoroutine(yeniLevel());
        }
    }
     IEnumerator yeniLevel()
    {
        donenCember.GetComponent<Dondurme>().enabled = false;
        anaCember.GetComponent<Anacember>().enabled = false;
        yield return new WaitForSeconds(0.5f);
        if (kontrol)
        {
            animator.SetTrigger("YeniLevel");
            yield return new WaitForSeconds(1.5f);
            SceneManager.LoadScene(int.Parse(SceneManager.GetActiveScene().name) + 2);
        }
        
    }

    public void OyunBitti()
    {
        StartCoroutine(CagrılanMetod());

    }
     IEnumerator CagrılanMetod()
    {
        donenCember.GetComponent<Dondurme>().enabled = false;
        anaCember.GetComponent<Anacember>().enabled = false;
        animator.SetTrigger("OyunBitti");
        kontrol = false;
        yield return new WaitForSeconds(1);//1 saniye bekletiyoruz.
        
        SceneManager.LoadScene("AnaMenu");

    }
}
