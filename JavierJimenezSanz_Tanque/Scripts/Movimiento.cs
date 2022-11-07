using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    //Variable de velocidad
    public float vel;


    // Update is called once per frame
    void Update()
    {
        Desplazamiento();



    }
    public void Desplazamiento()
        {

        //Inputs para definir teclas de movimiento
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) {

            //Desplazamos el eje Z 
            this.transform.Translate(0, 0, vel* Time.deltaTime);
}

if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
{

    this.transform.Translate(0, 0, -vel * Time.deltaTime);
}


        }
    public class CuentaAtras()
        {



        }


}
