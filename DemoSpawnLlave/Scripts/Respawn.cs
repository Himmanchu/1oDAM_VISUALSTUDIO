using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    //Variable con punto de respawn
    public GameObject ObjRespawn;


    // Start is called before the first frame update
    void Start()
    {
        // Al comienzo: colocamos el punto de respawn en la misma posición que el jugador
        ObjRespawn.transform.position = this.transform.position;
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Respawn")
        {
            //Volver a aparecer en el punto original
            this.transform.position = ObjRespawn.transform.position;

        }
       
        
    }
}
