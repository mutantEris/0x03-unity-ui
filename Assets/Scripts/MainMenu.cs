using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public void PlayMaze()
    {
        SceneManager.LoadScene("maze");
    }
    public void QuitMaze()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }
}