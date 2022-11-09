using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    //Ref Variables velocidad de movimiento y giro
    public int vel;
    public int velRot;

    //Ref Animación
    public Animator miAnim;

    public int Esferas;

    // Update is called once per frame
    void Update()
    {
        controlAvion();
  

    }

    void controlAvion()
    {

        //Movimiento hacia adelante continuo del avión
        this.transform.Translate(0, 0, vel * Time.deltaTime);

        //Rotación física del avión + animación
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Rotate(-velRot * Time.deltaTime, 0, 0);
            miAnim.SetBool("TurnUp", true);
        }
        else
        {
            miAnim.SetBool("TurnUp", false);
        }

        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Rotate(velRot * Time.deltaTime, 0, 0);
            miAnim.SetBool("TurnDown", true);
        }
        else
        {
            miAnim.SetBool("TurnDown", false);
        }

        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Rotate(0, -velRot * Time.deltaTime, 0);
            miAnim.SetBool("TurnL", true);
        }
        else
        {
            miAnim.SetBool("TurnL", false);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Rotate(0, velRot * Time.deltaTime, 0);
            miAnim.SetBool("TurnR", true);
        }
        else
        {
            miAnim.SetBool("TurnR", false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        //Si tocamos un objeto con el tag Esfera
        if (other.gameObject.tag == "Esferas")
        {
            //Lo eliminamos
            Destroy(other.gameObject);

            //Contamos las esferas
            Esferas++;
                Debug.Log("Contador de Esferas:" + Esferas);

        }
    }




}
