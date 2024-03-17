using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] public AudioSource mainMenuMusic;
    
    public void OnEnable()
    {
        mainMenuMusic.Play();
    }

    public void Start()
    {
        Time.timeScale = 1f;
    }
    
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log("PlayGame");
        mainMenuMusic.Stop();
    }

    public void QuitGame()
    {
        mainMenuMusic.Stop();
        Application.Quit();
        Debug.Log("QuitGame");
    }
}
