using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticaV3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 pos1;
        pos1 = new Vector3(5, 1, 6);

        Vector3 finalSumatorio;
        finalSumatorio = new Vector3(8, 1, 4);

        Vector3 pos2;
        pos2 = finalSumatorio - pos1;

        Vector3 finalResta;
        finalResta = new Vector3(2, -2, 4);

        Vector3 pos3;
        pos3 = pos1 - finalResta;

        Debug.Log("El vector 2 tiene el valor: " + pos2);
        Debug.Log("El vector 3 tiene el valor: " + pos3);
        Debug.Log("La suma del vector 1 y el vector 2 es: " + (pos1 + pos2));
        Debug.Log("La resta del vector 1 menos el vector 3 es: " + (pos1 - pos3));



    }

    // Update is called once per frame
    void Update()
    {

    }
}
