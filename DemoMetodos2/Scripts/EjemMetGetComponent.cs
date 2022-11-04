using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemMetGetComponent : MonoBehaviour
{
    public Renderer miRender;
    public Collider miCollider;
    public Rigidbody miRigid;

    // Start is called before the first frame update
    void Start()
    {
        //Obtener o buscar referencia del componente tipo Renderer
        miRender = this.GetComponent<Renderer>();

        //Obtener o buscar referencia del componente tipo Collider
        miCollider = this.GetComponent<Collider>();


        miRigid = this.GetComponent<Rigidbody>();

        Debug.Log(miRender);
        Debug.Log(miCollider);
        Debug.Log(miRigid);

        if (miRender == null)
        {
            Debug.Log("Falta el renderer");
        }

        if (miRigid == null)
        {
            Debug.Log("Falta el rigidbody");
        }

    }
        // Update is called once per frame
        void Update()
    {
        
    }
}
