using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condiciones1 : MonoBehaviour {

	// Use this for initialization
	void Start () {

		int numMisterioso;  //Creamos una variable te tipo numero entero
		numMisterioso = Random.Range(1,20);  //Se guardará en la variable un valor aleatorio entre 1 y 19

        Debug.Log("El número misterioso es: " + numMisterioso);

		if (numMisterioso > 5 && numMisterioso <= 15)
        {
			
				Debug.Log("Correcto");
        }

		else
		{
            Debug.Log("Incorrecto");
        }

		//Se deben crear una serie de ordenes y condiciones con el fin de
		// 1: que por consola salta el valor de numMisterioso cada vez que se ejecute (se le de al play)
		// 2: que la consola diga "Correcto" cuando el numero misterioso es mayor que 5 y menor(o igual) que 15
		// 3: que la consola diga “Incorrecto” cuando el anterior punto no se cumpla


	}
}
