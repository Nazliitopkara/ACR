using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulmacaTik2 : MonoBehaviour
{
    public GameObject kgt1;
    void Start()
    {
        kgt1.SetActive(false);
    }

    private void OnMouseDown()
    {
        if (this.name == "parsomenK")
        {
            StartCoroutine(kagit1());
        }

        if (this.name == "parsomenA")
        {
            StartCoroutine(kagit1());
        }

        if (this.name == "parsomenI")
        {
            StartCoroutine(kagit1());
        }

        if (this.name == "parsomenL")
        {
            StartCoroutine(kagit1());
        }

        if (this.name == "parsomenR")
        {
            StartCoroutine(kagit1());
        }

        if (this.name == "parsomenN")
        {
            StartCoroutine(kagit1());
        }

        IEnumerator kagit1()
        {
            kgt1.SetActive(true);
            yield return new WaitForSeconds(3f);
            kgt1.SetActive(false);
        }
    }

    
}
