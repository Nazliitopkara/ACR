using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SayfaDegistir : MonoBehaviour
{
    public void EkranDegistir()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Duvar4()
    {
        SceneManager.LoadScene("Duvar1");
    }

    public void EkranDegistirGeri()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void Duvar1()
    {
        SceneManager.LoadScene("Duvar4");
    }

    public void Duvar1_() // alt kýsma gidiyor
    {
        SceneManager.LoadScene("Duvar1");
    }
    public void Duvar2_() // alt kýsma gidiyor
    {
        SceneManager.LoadScene("Duvar2");
    }

    public void Duvar3_() // alt kýsma gidiyor
    {
        SceneManager.LoadScene("Duvar3");
    }

    public void Duvar4_() // alt kýsma gidiyor
    {
        SceneManager.LoadScene("Duvar4");
    }

}
