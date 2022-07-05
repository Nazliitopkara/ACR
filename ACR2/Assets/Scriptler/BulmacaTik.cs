using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulmacaTik : MonoBehaviour
{
    public GameObject kgt1;
    public GameObject kgt2;

    void Start()
    {
        kgt1.SetActive(false);
        kgt2.SetActive(false);
    }
    private void OnMouseDown()
    {
        if (this.tag == "kagitt")
        {
            StartCoroutine(kagit1());
            StartCoroutine(kagit2());
        }

        IEnumerator kagit1()
        {
            kgt1.SetActive(true);
            yield return new WaitForSeconds(3f);
            kgt1.SetActive(false);
        }

        IEnumerator kagit2()
        {
            kgt2.SetActive(true);
            yield return new WaitForSeconds(5f);
            kgt2.SetActive(false);
        }
    }
}
