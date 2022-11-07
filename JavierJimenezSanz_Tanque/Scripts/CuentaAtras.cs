using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuentaAtras : MonoBehaviour
{
   
    public float countDown;

    // Update is called once per frame
    void Update()
    {
        //Cuenta atrás en base al valor que se de a la variable

        if (countDown > 0)
        {
            /*convertimos el valor float en un integer redondeando los decimales a numeros enteros
            e iniciamos la cuenta atrás*/

            countDown -= Time.deltaTime;
            float f = countDown;
            int i = (int)Math.Round(f);

            Debug.Log(i);
            if (countDown < 0 )
            {
                Debug.Log("Te has quedado sin gasolina");
            }


        }

    }
}
