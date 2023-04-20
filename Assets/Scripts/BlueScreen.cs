using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class BlueScreen : MonoBehaviour
{
    public GameObject blueScreen;
    public AudioSource blueSource;
    public GameObject canvasToDelete;
    public GameObject texto;
    private readonly float tiempoEspera = 5f;


    private void Start()
    {
        StartCoroutine(AparecerTexto());
    }
    public void FinalScreen()
    {
        blueScreen.SetActive(true);
        blueSource.Play();
        canvasToDelete.SetActive(false);
    }

    IEnumerator AparecerTexto()
    {
        yield return new WaitForSeconds(tiempoEspera);
        texto.SetActive(true);
    }
}
