using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemCollision : MonoBehaviour
{

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log(this.name);
        Debug.Log("Entro en la colisión");

    }

    private void OnCollisionStay(Collision other)
    {
        Debug.Log("Sigo en la colisión");

    }

    private void OnCollisionExit(Collision other)
    {
        Debug.Log("Salgo de la colisión");

    }
}
