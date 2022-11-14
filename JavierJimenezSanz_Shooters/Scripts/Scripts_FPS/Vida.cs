using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Vida : MonoBehaviour
{

    public Image barra;
    public int vida = 5;
    public int maxVida = 5;

    public GameObject cam;


    // Start is called before the first frame update
    void Start()
    {
      
    }


    private void OnCollisionEnter(Collision other)
    {
        //Chequear que chocas con un enemigo
        if (other.gameObject.tag == "Fire")
        {
            vida = vida - 1;

        }
        if (other.gameObject.tag == "Botiquin")
        {
            vida = vida + 1;
            Destroy(other.gameObject);
        }

        //Si me quedo sin vida, mueres y pasa a la cámara principal
        if (vida == 0)
        {
            Destroy(this.gameObject);
            cam.SetActive(true);
        }

        ActualizarBarra();
    }

    void ActualizarBarra()
    {
        //Regla de tres
        float vidaParaImagen = (float)vida / maxVida;

        //Asignar el resultado a la imagen
        barra.fillAmount = vidaParaImagen;

    }
}
