using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asnwer1 : MonoBehaviour
{
    public GameObject justAGame;
    public GameObject question1;
    public GameObject BagFaceNoRisk;
    public GameObject mainCamera;
    public GameObject finalCamera;
    public GameObject blackScreen;
    public AudioSource horrorHit;
    public Animator animator;
    //public GameObject questionCanvas;
    public GameObject ligths;
    public float deathDelay = 4f;
    public GameObject finalMessage;
    public GameObject canvasToDelete;

    public void ChangeCamera()
    {
        // Desactivar Camera1
        mainCamera.SetActive(false);
        // Activar Camera2
        finalCamera.SetActive(true);
    }


    public void ResponderConMiedo()
    {
        question1.SetActive(false);
        justAGame.SetActive(true); 
    }


    public void ResponderSinRiesgo()

    {
        
        blackScreen.SetActive(true);
        horrorHit.Play();
        question1.SetActive(false);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        StartCoroutine(DeathCoroutine());
        Debug.Log("No hay riesgo");

    }

    IEnumerator DeathCoroutine()
    {
        yield return new WaitForSeconds(deathDelay);
        animator.SetBool("Activefade", true);
        canvasToDelete.SetActive(false);    
        Debug.Log("sea ctivo la corrutina");
        ligths.SetActive(true);
        finalMessage.SetActive(true);
        ChangeCamera();
        BagFaceNoRisk.SetActive(true);



    }

}
