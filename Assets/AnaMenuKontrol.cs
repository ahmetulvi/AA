using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnaMenuKontrol : MonoBehaviour
{
    public void OyunaGit()
    {
        int kayıtlılevel = PlayerPrefs.GetInt("kayıt");
        if (kayıtlılevel==0)
        {
            SceneManager.LoadScene(kayıtlılevel+1);

        }
        else
        {
            SceneManager.LoadScene(kayıtlılevel);
        }

    }
    public void Cık()
    {
        Debug.Log("Girdi");
        Application.Quit();

    }
}
