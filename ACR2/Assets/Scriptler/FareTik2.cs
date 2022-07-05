using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FareTik2 : MonoBehaviour
{
    public GameObject kgt1;
    public GameObject kgt2;
    public GameObject kgt3;

    private void Start()
    {
        kgt1.SetActive(false);
        kgt2.SetActive(false);
        kgt3.SetActive(false);
    }

    private void OnMouseDown()
    {
        if (this.name == "At")
        {
            StartCoroutine(kagit2());
        }

        if (this.name == "Koltuk2")
        {
            StartCoroutine(kagit1());
        }

        if (this.name == "iskelet1")
        {
            StartCoroutine(kagit2());
        }

        if (this.name == "pencere")
        {
            StartCoroutine(kagit1());
        }

        if (this.name == "sandalye")
        {
            StartCoroutine(kagit3());
        }

        if (this.name == "ayna")
        {
            StartCoroutine(kagit1());
        }

        if (this.name == "ayna1")
        {
            StartCoroutine(kagit1());
        }

        if (this.name == "ayna2")
        {
            StartCoroutine(kagit1());
        }

        if (this.name == "j")
        {
            StartCoroutine(kagit2());
        }

        if (this.name == "orumcek")
        {
            StartCoroutine(kagit3());
        }

        if (this.name == "Geyik1")
        {
            StartCoroutine(kagit1());
        }

        if (this.name == "Geyik")
        {
            StartCoroutine(kagit1());
        }

        if (this.name == "sandik")
        {
            kgt2.SetActive(true);
            kgt3.SetActive(true);
        }

        if (this.name == "parsomenK")
        {
            SceneManager.LoadScene("Duvar2Bulmaca");
        }

        if (this.name == "parsomenA")
        {
            SceneManager.LoadScene("Duvar2_1Bulmaca");
        }

        if (this.name == "parsomenI")
        {
            SceneManager.LoadScene("Duvar3Bulmaca");
        }

        if (this.name == "parsomenL")
        {
            SceneManager.LoadScene("Duvar3_1Bulmaca");
        }

        if (this.name == "parsomenR")
        {
            SceneManager.LoadScene("Duvar4Bulmaca");
        }

        if (this.name == "parsomenN")
        {
            SceneManager.LoadScene("Duvar4_1Bulmaca");
        }

        if (this.name == "kitappp")
        {
            SceneManager.LoadScene("Duvar4_2Bulmaca");
        }

        if (this.name == "kagitt1")
        {
            SceneManager.LoadScene("Duvar1Bulmaca");
        }
    }
    IEnumerator kagit2()
    {
        kgt2.SetActive(true);
        yield return new WaitForSeconds(3f);
        kgt2.SetActive(false);
    }

    IEnumerator kagit1()
    {
        kgt1.SetActive(true);
        yield return new WaitForSeconds(3f);
        kgt1.SetActive(false);
    }

    IEnumerator kagit3()
    {
        kgt3.SetActive(true);
        yield return new WaitForSeconds(3f);
        kgt3.SetActive(false);
    }

}

