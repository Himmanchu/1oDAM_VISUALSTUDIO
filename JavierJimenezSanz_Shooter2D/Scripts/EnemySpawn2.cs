using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn2 : MonoBehaviour
{

    public GameObject enemy;


    public float cont;
    public float lim = 1;

    public int min = 1;
    public int max = 10;

    //Los enemigos que salgan de este punto, tendrán esta dirección

    public Vector3 dirSpawn = Vector3.left;

    // Start is called before the first frame update
    void Start()
    {
        CalculoAleatorio();
    }

    // Update is called once per frame
    void Update()
    {
        //Actualizar el contador
        cont = cont + Time.deltaTime;

        if (cont > lim)
        {
            //Creamos nuevo enemigo que va girado mirando hacia delante
            GameObject nuevoEnemy = (GameObject)Instantiate(enemy, this.transform.position, this.transform.rotation = Quaternion.Euler(0, 180, 0));
            nuevoEnemy.GetComponent<MovEnemy>().dir = dirSpawn; //Actualizar dirección del enemigo creado
            cont = 0; //Empezamos a contar de nuevo
            CalculoAleatorio();
        }

    }

    void CalculoAleatorio()
    {
        lim = Random.Range(min, max);
    }
}
