using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class SkipVideoController : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public string nextSceneName = "scene1";
    public Button skipButton;
    // Start is called before the first frame update
    void Start()
    {
        if (videoPlayer != null){
            videoPlayer.Play();
            videoPlayer.loopPointReached += OnVideoEnd;
        }
        if(skipButton != null){
            skipButton.onClick.AddListener(SkipVideo);
        }
    }
    public void SkipVideo()
    {
        SceneManager.LoadScene(1);
    }

    void OnVideoEnd(VideoPlayer vp)
    {
        SceneManager.LoadScene(1);
    }
}