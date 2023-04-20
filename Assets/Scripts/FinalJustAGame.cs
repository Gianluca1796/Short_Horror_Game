using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalJustAGame : MonoBehaviour
{
    public GameObject finalJustAGame;
    public GameObject justAGame;

    public void respuestaFinal()
    {
        justAGame.SetActive(false);
        finalJustAGame.SetActive(true);
    }
}
