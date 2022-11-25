using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoEnemy : MonoBehaviour
{

    //Ref sonidos
    public AudioSource Sonidos;
    public AudioClip son1;

    private void Start()
    {
        Sonidos.clip = son1;
        Sonidos.Play();
    }

}
