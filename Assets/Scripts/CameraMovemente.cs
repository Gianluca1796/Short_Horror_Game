using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovemente : MonoBehaviour
{

    public float mouseSensitivity = 300f;
    public Transform player;
    float xRotation = 0;


    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        //C�mara normal, si pusiera un += ser�a la camara invertida
        xRotation -= mouseY;
        //Impide que la c�mara rote mas de 90 grados para arriba y para abajo   
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        //Indicamos que rote la c�rama en el eje X
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        //Indicamos que el player(GameObject) va a rotar en el eje X por el movimiento del mouse en X
        player.Rotate(Vector3.up * mouseX);


    }
}
