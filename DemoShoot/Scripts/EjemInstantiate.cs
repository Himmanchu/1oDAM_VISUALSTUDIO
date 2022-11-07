using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemInstantiate : MonoBehaviour
{
    public GameObject refObjetoOriginal;


    // Start is called before the first frame update
    void Start()
    {
        //Ejem Método Instantiate
        // 1) objeto a clonar
        // 2) dónde lo clonamos
        // 3) rotación del clon
        Instantiate(refObjetoOriginal, this.transform.position, this.transform.rotation);


    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(refObjetoOriginal, this.transform.position, this.transform.rotation);
    }
}
