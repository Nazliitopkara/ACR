using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Sifre : MonoBehaviour
{
    public string theName;
    public GameObject inputField;
    public GameObject kitap;
    public GameObject sfr,sfr1;
    public GameObject kapi, kapi1,kilit;
    public UnityEngine.UI.Button buton;

    public void sifree()
    {
        theName = inputField.GetComponent<Text>().text;
        if (theName == "karanlýk" || theName == "KARANLIK")
        {
            kitap.SetActive(false);
            SceneManager.LoadScene("Duvar4Sifre");
        }

        if (theName == "3712")
        {
            kilit.SetActive(false);
            kapi.SetActive(true);
            kapi1.SetActive(false);
        }
    }

    private void OnMouseDown()
    {
        if (this.name == "KGT")
        {
            sfr.SetActive(true);
            sfr1.SetActive(false);
            buton.gameObject.SetActive(true);
        }

        if (this.name == "kilit")
        {
            sfr.SetActive(true);
            sfr1.SetActive(true);
            buton.gameObject.SetActive(true);
        }
    }

    public void tik() // alt kýsma gidiyor
    {
        sfr.SetActive(true);
        sfr1.SetActive(false);
        buton.gameObject.SetActive(false);
    }
}
