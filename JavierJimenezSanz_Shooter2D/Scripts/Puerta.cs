using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Puerta : MonoBehaviour
{
    //Ref llaves y la imagen en el canvas
    public Image Llaves;
    public int keys=2;
    public int maxKeys = 3;

    public Animator miAnim;

    // Start is called before the first frame update
    void Start()
    {
        keys = 0;
        ActualizarLlaves();
    }

    private void Update()
    {
        AbrirPuerta();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Key")
        {
         
            //Cogemos una llave
            keys ++;

            //Eliminamos la llave
            Destroy(other.gameObject);

        }
        ActualizarLlaves();

    }
    void ActualizarLlaves()
    {
        //Regla de 3
        float llavesPantalla = (float)keys/maxKeys;

        //Asignar resultado a la imagen
        Llaves.fillAmount = llavesPantalla;
    }

    void AbrirPuerta()
    {
        if (keys == 2)
        {
            miAnim.SetBool("BAbrirPuerta", true);
        }

    }
}