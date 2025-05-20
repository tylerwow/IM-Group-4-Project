using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    public PlayerManager playerManager;
    public Text roomText;
    public Text tutorialText;

    public GameObject pauseMenu;
    bool isPaused;

    void Update()
    {
        roomText.text = playerManager.roomCount.ToString();

        if (playerManager.lastRoomName() == "Room1")
        {
            tutorialText.text = "[WASD] to move";
        }
        else if (playerManager.lastRoomName() == "Room2")
        {
            tutorialText.text = "[C] to switch camera";
        }
        else if (playerManager.lastRoomName() == "Room3")
        {
            tutorialText.text = "[SPACE] to jump";
        }
        else if (playerManager.lastRoomName() == "Room4")
        {
            tutorialText.text = "[E] to press button";
        }
        else
        {
            tutorialText.text = "";
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
        }

        if (isPaused)
        {
            PauseGame();
        }
        else
        {
            ResumeGame();
        }
    }

    public void PauseGame()
    {
        isPaused = true;
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {
        isPaused = false;
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }
}
