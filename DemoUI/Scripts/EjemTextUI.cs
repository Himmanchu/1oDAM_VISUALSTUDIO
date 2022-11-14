using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EjemTextUI : MonoBehaviour
{
      public Text elTexto;

       public int punt;


    //Start is called before the first frame update
    void Start()
    {
        elTexto.text = "Puntuación: " + punt;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
