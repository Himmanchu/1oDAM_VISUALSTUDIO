using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuentaAtras : MonoBehaviour
{

    public int reloj = 5;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       if (reloj > 0)
        {
            
            reloj = reloj - 1;
            Debug.Log(reloj);
        }
        else {
            Debug.Log("El tiempo se ha acabado");
        }
        }
}
