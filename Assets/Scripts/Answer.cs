using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Answer : MonoBehaviour
{
    public GameObject question;
    public GameObject interactableZone;
    public GameObject question1;
    public GameObject blackScreen;
    public AudioSource horrorHit;
    public float deathDelay = 4f;
    public GameObject mainCamera;
    public GameObject finalCamera;
    public GameObject finalBagFace;
    public GameObject ligths;
    public GameObject finalMessage;
    public Animator animator;
    public GameObject canvasToDelete;



    public void ChangeCamera()
    {
        // Desactivar Camera1
        mainCamera.SetActive(false);
        // Activar Camera2
        finalCamera.SetActive(true);
    }





    public void ResponderSi()
    {
        Debug.Log("Dijo q si");
        question.SetActive(false); 
        blackScreen.SetActive(true);
        horrorHit.Play();
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        StartCoroutine(DeathCoroutine());
       

    }

    public void ResponderNo()
    {
        Debug.Log("Dijo q no");
        question.SetActive(false);
        interactableZone.SetActive(false);
        question1.SetActive(true);
    }


    IEnumerator DeathCoroutine()
    {
        yield return new WaitForSeconds(deathDelay);
        animator.SetBool("Activefade", true);
        ligths.SetActive(true);
        finalMessage.SetActive(true);
        canvasToDelete.SetActive(false);
        ChangeCamera();
        finalBagFace.SetActive(true);



    }


    
}
