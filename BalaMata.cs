using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaMata : MonoBehaviour
{
    //Referencia del efecto de partículas
    public GameObject efectoOriginal;


    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Enemy")
        {

            //Destruir el otro objeto (enemigo)
            Destroy(other.gameObject);

            //Enemigo explota
            Instantiate(efectoOriginal, other.gameObject.transform.position, this.transform.rotation);

          
        }
        //Destruir la propia bala
        Destroy(this.gameObject);


    }
}
