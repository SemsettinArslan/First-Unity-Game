using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject restartMenu;
    public GameObject finishMenu;
    public GameObject pauseButton;
    public GameObject WinButton;

    //Panel ve buton kontrollerinin metotlar�
    public void PlayGame()
    {
        Debug.Log("Oyun ba�lad�.");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Debug.Log("Oyundan ��k�ld�.");
        Application.Quit();
    }

    public void PauseGame()
    {
        Debug.Log("Oyun durdu.");
        pauseMenu.SetActive(true);
        pauseButton.SetActive(false);
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {
        Debug.Log("Oyun devam ediyor");
        pauseMenu.SetActive(false);
        pauseButton.SetActive(true);
        Time.timeScale = 1;
    }
    public void ReturnGameMenu()
    {
        Debug.Log("Ana men�ye d�n�ld�.");
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;
    }

    public void RestartGame()
    {
        Debug.Log("Oyun tekrar ba�lat�ld�.");
        Time.timeScale = 1;
        pauseButton.SetActive(true);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void NextScene()
    {
        Debug.Log("Sonraki sahneye ge�ildi.");
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
