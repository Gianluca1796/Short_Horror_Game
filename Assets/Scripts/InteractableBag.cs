using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InteractableBag : MonoBehaviour
{
    public GameObject trashMessage;
    private bool objetoYaDestruido = false;
    private bool isInTrashZone;
    public Animator trashAnimator;
    public GameObject BagFace;
    public GameObject Question;
    public ResetCamera resetCamera;
    public int clicksCount = 0;







    void Update()
    {
        InteractTrashBag();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (objetoYaDestruido == false)
            {
                trashMessage.SetActive(true);
                isInTrashZone = true;
                Debug.Log(isInTrashZone);
            }
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (objetoYaDestruido == false)
            {
                trashMessage.SetActive(false);
                isInTrashZone = false;
                Debug.Log(isInTrashZone);
            }
        }
    }
    void InteractTrashBag()
    {

        if (isInTrashZone && Input.GetMouseButtonDown(0))
        {
            resetCamera.BloquearCamaraHaciaAdelante();
            Debug.Log("Hice lcikc y estoy dentro");
            trashAnimator.SetTrigger("Movement");
            clicksCount++;


            if (clicksCount == 1)
            {
                BagFace.SetActive(true);
                Destroy(trashMessage);
                objetoYaDestruido = true;
                Question.SetActive(true);
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }

            if (clicksCount >= 3)
            {
                Debug.Log("Se han detectado 3 clics.");
                clicksCount = 0;
                // Aquí puedes llamar a la función o ejecutar la acción deseada
            }

        }
    }


}

