using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour
{
    private bool juegoPausado = false;
    public GameObject player;
    public GameObject pauseMenu;




    private void Start()
    {
        player = GameObject.Find("Player");
        
    }
    void Update()
    {
        // Si se presiona la tecla "P"
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Si el juego está pausado, lo reanuda
            if (juegoPausado)
            {
                Time.timeScale = 1;
                juegoPausado = false;
                pauseMenu.SetActive(false);
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.None;
                player.GetComponent<PlayerMove>().enabled = true;


            }
            // Si el juego no está pausado, lo pausa
            else
            {
                Time.timeScale = 0;
                pauseMenu.SetActive(true);
                juegoPausado = true;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                player.GetComponent<PlayerMove>().enabled = false;

            }
        }
    }

    public void Salir()
    {
        Debug.Log("salio");
        Application.Quit();
    }
}
