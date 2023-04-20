using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMessage : MonoBehaviour
{
    public GameObject carMessage;
    private bool inCarZone;
    public GameObject lightsOff;

    private void Update()
    {
        InteractCar();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inCarZone = true;   
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            carMessage.SetActive(false);
            inCarZone = false;
        }
    }

    void InteractCar()
    {
        if (inCarZone && Input.GetMouseButtonDown(0))
        {
            carMessage.SetActive(true);
            lightsOff.SetActive(true);
        }
    }
}
