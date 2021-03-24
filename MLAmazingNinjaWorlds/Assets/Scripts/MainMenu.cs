using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Level1()
    {
        PlayerPrefs.DeleteKey("LIVES_LEFT");
        SceneManager.LoadScene("Level1");
    }

    public void Level2()
    {
        //PlayerPrefs.DeleteKey("LIVES_LEFT");
        SceneManager.LoadScene("Level2");
    }

    public void Level3()
    {
        //PlayerPrefs.DeleteKey("LIVES_LEFT");
        SceneManager.LoadScene("Level3");
    }

}
