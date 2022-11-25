using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Vida : MonoBehaviour
{
    //Ref vida e imagen de vida
    public Image corazones;
    public int vida = 3;
    public int maxVida = 5;

    public GameObject cam;

    //Ref sonidos
    public AudioSource Sonidos;
    public AudioClip son1;
    public AudioClip son2;

    // Start is called before the first frame update
    void Start()
    {
        vida = 3;
    }
    private void Update()
    {
        ActualizarVida();
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            //Pierde vida
            vida -= 1;
            Sonidos.clip = son1;
            Sonidos.Play();
        }
        if (other.gameObject.tag == "Medkit")
        {
            //Ganas vida
            vida++;
            Sonidos.clip = son2;
            Sonidos.Play();
            Destroy(other.gameObject);
            ActualizarVida();
        }
        ChekinMuerte();
    }

        void ActualizarVida()
    {
        //Regla de 3
        float vidaPantalla = (float)vida / maxVida;

        //Asignar resultado a la imagen
        corazones.fillAmount = vidaPantalla;
    }

    void ChekinMuerte()
    {
        if (vida <= 0)
        {
            Destroy(this.gameObject);

            SceneManager.LoadScene("GameOver");
        }
    }
}
