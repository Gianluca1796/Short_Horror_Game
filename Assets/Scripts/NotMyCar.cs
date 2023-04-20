using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotMyCar : MonoBehaviour
{
    public GameObject notMycar;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            notMycar.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            notMycar.SetActive(false);
        }
    }
}
