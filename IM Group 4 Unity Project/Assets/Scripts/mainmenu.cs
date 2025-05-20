using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject controlsMenu;

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ShowControls()
    {
        mainMenu.SetActive(false);
        controlsMenu.SetActive(true);
    }

    public void HideControls()
    {
        mainMenu.SetActive(true);
        controlsMenu.SetActive(false);
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
