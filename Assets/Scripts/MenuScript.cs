using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void Menu()
    {
       SceneManager.LoadScene("MenuScript");
    }

    // Update is called once per frame
    public void StartGame()
    {
        SceneManager.LoadScene("Bowling");
    }

    public void Quit()
    {
        Application.Quit();
    }
}