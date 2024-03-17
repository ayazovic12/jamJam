using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class nextLevel : MonoBehaviour
{
    [SerializeField]
    VideoPlayer player;

    private void Start()
    {
        player.loopPointReached += ReadyToNextLevel;

    }

    void ReadyToNextLevel(VideoPlayer player)
    {
        SceneManager.LoadScene("Level1");
    }
}
