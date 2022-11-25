using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransicionNivel : MonoBehaviour
{
    //Ref llaves especiales
    public GameObject key1;
    public GameObject key2;
    public GameObject key3;
    public GameObject key4;


    private void OnTriggerEnter(Collider other)
  
    {
        if (other.gameObject.tag == "Puerta")
        {
            //Activamos las llaves especiales
            key1.SetActive(true);
            key2.SetActive(true);
            key3.SetActive(true);
            key4.SetActive(true);
        }

        if(other.gameObject.tag == "PuertaEspecial")
        {
            //Pasamos al nivel 2
            SceneManager.LoadScene("Level2");
        }
    }
  
}
