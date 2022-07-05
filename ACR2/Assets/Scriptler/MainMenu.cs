using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // Sahneler aras� ge�isi sa�layan kod
    }

    public void QuitGame()
    {
        Debug.Log("oyundan ��kt�k");
        Application.Quit();
    }
}
