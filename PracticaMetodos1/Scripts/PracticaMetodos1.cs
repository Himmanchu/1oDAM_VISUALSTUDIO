using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticaMetodos1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Se hace la llamada al método Multiplicar
        Multiplicar(4, 6);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //Creamos el método multiplicar para que nos devuleva un tercer número resultante
    void Multiplicar(int num1, int num2)
    {
        int num3 = num1 * num2;

        Debug.Log(num3);

    }



}
