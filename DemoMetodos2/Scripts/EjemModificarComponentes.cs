using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemModificarComponentes : MonoBehaviour
{
    //Guardaremos la referencia del componente en esta variable
    public Renderer miRender;

    //Guardaremos la referencia del componente en esta variable
    public Collider miCollider;

    public Transform miTrans;


    // Start is called before the first frame update
    void Start()
    {


        //Activar el estado de trigger
        miCollider.isTrigger = true;

        //Desactiva el componente
        miCollider.enabled = false;


        
    }

    // Update is called once per frame
    void Update()
    {

        //! Con la esclamación invierte el valor: false -> true ; true -> false
        miRender.enabled = !miRender.enabled;
    }
}
