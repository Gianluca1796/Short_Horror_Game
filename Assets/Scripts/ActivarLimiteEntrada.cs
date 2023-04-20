using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarLimiteEntrada : MonoBehaviour
{

    public GameObject limiteEntrada;


    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            limiteEntrada.SetActive(true); 
        }
    }
}
