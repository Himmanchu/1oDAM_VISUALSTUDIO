using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemUIcheck : MonoBehaviour
{
public void Ejem1()
    {
        Debug.Log("Estoy dándole al toggle");
    }

    public void Ejem2(bool val)
    {
        if (val == true)
        {
            Debug.Log("Me han activado");
        }
        else
        {
            Debug.Log("Me han desactivado");
        }
    }
}
