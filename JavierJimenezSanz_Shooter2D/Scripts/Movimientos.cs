using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Movimientos : MonoBehaviour
{
    //Ref Animacion
    public Animator miAnim;

    public float velMovimiento;
    public float velSalto;

    public Rigidbody miRigid;
    public bool tocoSuelo;

    //Ref nº saltos que he hecho
    public int Saltos;


    // Start is called before the first frame update
    void Start()
    {
        Saltos = 0;
    }

    // Update is called once per frame
    void Update()
    {
        ControlPlayer();
        dobleSalto();

    }

    void ControlPlayer()
    {
    
        //Movernos lateralmente
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            miAnim.SetBool("BAndarDrcha", true);
            this.transform.rotation = Quaternion.Euler(0, 0, 0);
            this.transform.Translate(velMovimiento*Time.deltaTime, 0, 0);
        }
        else
        {
            miAnim.SetBool("BAndarDrcha", false);
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            miAnim.SetBool("BAndarIzq", true);
            this.transform.rotation = Quaternion.Euler(0, 180, 0);
            this.transform.Translate(velMovimiento * Time.deltaTime, 0, 0);
        }
        else
        {
            miAnim.SetBool("BAndarIzq", false);
        }


        //Agacharnos
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            miAnim.SetBool("BAgachar", true);
        
        }
        else
        {
            miAnim.SetBool("BAgachar", false);
        }

        //Saltar

        //Premisa: no tocamos suelo
        tocoSuelo = false;
        

        //Mirar si tocamos suelo realmente
        RaycastHit resultadoRayo;

        //Si no hemos saltado aún
        if (Physics.Raycast(this.transform.position, Vector3.down, out resultadoRayo, 0.66f))
        {
            if (resultadoRayo.transform.tag == "Suelo")
            {
                tocoSuelo = true; //Realmente sí tocamos suelo
            }
        }

        if((Input.GetKeyDown(KeyCode.UpArrow) && (tocoSuelo == true) || Input.GetKeyDown(KeyCode.W) && (tocoSuelo==true)))
        {
            miRigid.velocity = Vector3.up * velSalto; //Aplicar velocidad ascendente
            miAnim.SetTrigger("TSalto");

            //Aumenta el salto a 1
            Saltos=1;
        }
        
        //Ataques

        if (Input.GetKeyDown(KeyCode.N))
        {
            miAnim.SetTrigger("TPuno");
        }
     
        if (Input.GetKeyDown(KeyCode.B))
        {
            miAnim.SetTrigger("TPatada1");
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            miAnim.SetTrigger("THadouken");

        }
    }

    void dobleSalto()
    {
       
        if ((Input.GetKeyDown(KeyCode.UpArrow) && (tocoSuelo == false) && (Saltos > 0 && Saltos < 2) || Input.GetKeyDown(KeyCode.W) && (tocoSuelo == true) && (Saltos > 0 && Saltos < 2)))
        {
            miRigid.velocity = Vector3.up * velSalto; //Aplicar velocidad ascendente
            miAnim.SetTrigger("TSalto");

            //Reseteamos los Saltos
            Saltos =0;
        }

    }
   

}
