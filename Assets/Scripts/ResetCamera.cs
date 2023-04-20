using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetCamera : MonoBehaviour
{
    // Referencia a la cámara que se desea bloquear
    public GameObject mainCamera;
    public GameObject player;
    public GameObject position;



    private void Start()
    {
        mainCamera = GameObject.Find("Main Camera");
    } 

    //private void Update()
    //{
    //    // Si se presiona la tecla "R"
    //    if (Input.GetKeyDown(KeyCode.R))
    //    {
    //        // Reiniciar la rotación de la cámara
    //        BloquearCamaraHaciaAdelante();
    //    }
    //}


    // Función que bloquea la cámara y la hace mirar hacia adelante
    public void BloquearCamaraHaciaAdelante()
    {
        mainCamera.GetComponent<CameraMovemente>().enabled = false;
        mainCamera.transform.localRotation = Quaternion.identity;
        player.transform.localPosition = position.transform.localPosition;
        player.transform.localRotation = position.transform.localRotation;
    }
}
