using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    // Start is called before the first frame update
    public void OpenBattleGround()
    {
        SceneManager.LoadScene("BattleGround");
    }
    public void OpenMainMenu()
    {
        FindObjectOfType<AudioManager>().play("Select");
        SceneManager.LoadScene("mainMenu");
    }
    public void OpenSelectionMenu()
    {
        FindObjectOfType<AudioManager>().play("Select");
        SceneManager.LoadScene("UnitSelectMenu");
    }
}
