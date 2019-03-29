using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider volumeSlider;
    public AudioSource volumeAudio;
    void Start()
    {
        if(volumeAudio)
            volumeSlider.value = volumeAudio.volume;
    }
    public void OpenSettings()
    {
        SceneManager.LoadScene("Settings");
    }
    public void OpenBattleGround()
    {
        SceneManager.LoadScene("battleGround");
    }
    public void OpenMainMenu()
    {
        SceneManager.LoadScene("mainMenu");
    }
    public void QuitApp()
    {
        Application.Quit();

    }
    public void OpenSelectionMenu()
    {
        SceneManager.LoadScene("UnitSelectMenu");
    }
    public void VolumeController()
    {
        volumeAudio.volume = volumeSlider.value;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
