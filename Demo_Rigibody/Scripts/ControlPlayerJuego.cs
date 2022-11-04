using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPlayerJuego : MonoBehaviour
{

    public Rigidbody miRigid;
    public float velSalto;
    public Vector3 velMovimiento;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(velMovimiento);
        Salto();

     

        
    }

    //Creamos un método para no sobrecargar el Update

    void Salto()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            miRigid.velocity = new Vector3(0, velSalto, 0);
        }

    }

}
