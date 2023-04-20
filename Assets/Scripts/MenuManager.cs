using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.R))
        {
            StartAgain();
        }
    }
    public void IniciarJuego()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        Application.Quit(); 
    }

    public void StartAgain()
    {

        SceneManager.LoadScene("MainMenu");

    }
}
