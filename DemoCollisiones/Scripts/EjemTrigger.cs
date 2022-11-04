using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other.gameObject.name);
        Debug.Log(other.name);
        Debug.Log("Entro");
    }

    private void OnTriggerStay(Collider other)
    {
        //Debug.Log(other.gameObject.name);
        Debug.Log(other.name);
        Debug.Log("Sigo");
    }

    private void OnTriggerExit(Collider other)
    {
        //Debug.Log(other.gameObject.name);
        Debug.Log(other.name);
        Debug.Log("Salgo");
    }
}
