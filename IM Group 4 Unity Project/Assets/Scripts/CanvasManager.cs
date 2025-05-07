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
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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
        else {
            tutorialText.text = "";
        }
    }
}
