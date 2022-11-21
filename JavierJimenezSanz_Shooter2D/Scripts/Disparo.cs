using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    public GameObject bala;

    public float vel=14;

    public GameObject puntoDisparo;
    public Vector3 direcDisp = Vector3.right;

    public Animator miAnim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Actualizamos dirección correcta
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            direcDisp = Vector3.right;
        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            direcDisp = Vector3.left;
        }

     
        if (Input.GetKeyDown(KeyCode.M))
        {
            Disparar();
    
        }
    }

    void Disparar()
    {

        //Crear el clon y guardarlo en la variable
       GameObject newBala= (GameObject) Instantiate(bala, puntoDisparo.transform.position, this.transform.rotation);

        newBala.GetComponent<Rigidbody>().velocity = direcDisp * vel;

        //Destruir la bala que generamos con delay
        Destroy(newBala, 1);
    }
}
