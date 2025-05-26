using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class SkipVideoController : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public Button skipButton;
    public GameObject controls;

    string currentScene;

    void Start()
    {
        if (videoPlayer != null)
        {
            videoPlayer.Play();
            videoPlayer.loopPointReached += OnVideoEnd;
        }
        if (skipButton != null)
        {
            skipButton.onClick.AddListener(SkipVideo);
        }

        currentScene = SceneManager.GetActiveScene().name;
    }

    public void SkipVideo()
    {
        SceneManager.LoadScene(2);
    }

    void OnVideoEnd(VideoPlayer vp)
    {
        if (currentScene == "Intro")
        {
            SceneManager.LoadScene(2);
        }
        if (currentScene == "End")
        {
            controls.SetActive(true);
        }
    }
}