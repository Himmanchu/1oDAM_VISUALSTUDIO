using UnityEngine;
using UnityEngine.SceneManagement;

public class Salida : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        //Chequear la salida
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menu");

            //Cierra el programa
            //  Application.Quit();

        }
    }
}
