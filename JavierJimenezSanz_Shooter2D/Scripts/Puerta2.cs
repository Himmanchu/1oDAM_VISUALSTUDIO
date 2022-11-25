using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Puerta2 : MonoBehaviour
{
    //Ref llaves especiales y la imagen en el canvas
    public Image Llaves2;
    public int SpecialKeys = 4;
    public int maxSpecialKeys = 4;
    public Animator miAnim;

    //Ref sonidos
    public AudioSource Sonidos;
    public AudioClip son1;
    public AudioClip son2;

    // Start is called before the first frame update
    void Start()
    {
        SpecialKeys = 0;
        ActualizarLlavesEspeciales();
    }

    private void Update()
    {
        AbrirPuertaSpecial();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "SpecialKey")
        {

            //Cogemos una llave
            SpecialKeys++;

            //Reproducimos sonido
            Sonidos.clip = son1;
            Sonidos.Play();

            //Eliminamos la llave
            Destroy(other.gameObject);

            ActualizarLlavesEspeciales();
        }
    }
    void ActualizarLlavesEspeciales()
    {
        //Regla de 3
        float llavesPantalla2 = (float)SpecialKeys / maxSpecialKeys;

        //Asignar resultado a la imagen
        Llaves2.fillAmount = llavesPantalla2;
    }


    void AbrirPuertaSpecial()
    {
        if (SpecialKeys == 4)
        {
            miAnim.SetBool("BPE_abierta", true);

        }

    }
}