using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GB_MenuManager : MonoBehaviour
{
    public string playGame;
    public string menuScene;
    public GameObject mainMenu;
    public GameObject optionsMenu;
    public GameObject storeMenu;

    private void Awake()
    {
        GB_VolumeSlider.volumeSlider = 1f;
    }


    private void Start()
    {
        optionsMenu.SetActive(false);
        storeMenu.SetActive(false);
        mainMenu.SetActive(true);
        /*FindObjectOfType<AudioManager>().StopPlaying("OutsideMusic");
        FindObjectOfType<AudioManager>().StopPlaying("DungeonMusic");
        FindObjectOfType<AudioManager>().StopPlaying("BossMusic");
        FindObjectOfType<AudioManager>().Play("MenuMusic");*/
    }


    public void PlayGame()
    {
        SceneManager.LoadScene(playGame);
        /*FindObjectOfType<AudioManager>().StopPlaying("MenuMusic");
        FindObjectOfType<AudioManager>().Play("OutsideMusic");*/
    }

    public void OptionsMenu()
    {
        optionsMenu.SetActive(true);
        storeMenu.SetActive(false);
        mainMenu.SetActive(false);
    }

    public void StoreMenu()
    {
        optionsMenu.SetActive(false);
        storeMenu.SetActive(true);
        mainMenu.SetActive(false);
    }

    public void _MainMenu()
    {
        optionsMenu.SetActive(false);
        storeMenu.SetActive(false);
        mainMenu.SetActive(true);
    }

    public void GameToMainMenu()
    {
        SceneManager.LoadScene(menuScene);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game OK");
    }

    /*public void SetVolume(float volume)
    {
        AudioManager.volumeSlider = volume;
    }*/


    List<int> widths = new List<int>() { 568, 960, 1280, 1980 };
    List<int> heights = new List<int>() { 320, 540, 800, 1080 };

    public void SetScreensize(int index)
    {
        bool fullscreen = Screen.fullScreen;
        int width = widths[index];
        int height = heights[index];
        Screen.SetResolution(width, height, fullscreen);
    }

    public void SetFullScreen(bool _fullscreen)
    {
        Screen.fullScreen = _fullscreen;
    }
    /*public void Scroll()
    {
        FindObjectOfType<AudioManager>().Play("Scroll");
    }
    public void Pause()
    {
        FindObjectOfType<AudioManager>().Play("Pause");
    }
    public void Ok()
    {
        FindObjectOfType<AudioManager>().Play("Ok");
    }
    public void Play()
    {
        FindObjectOfType<AudioManager>().Play("Play");
    }*/
}