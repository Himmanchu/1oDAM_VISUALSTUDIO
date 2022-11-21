using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
   public void Empezar() { 
        SceneManager.LoadScene("Level1");
    }

    public void Niveles()
    {
        SceneManager.LoadScene("Niveles");
    }
    public void Nivel1()
    {
        SceneManager.LoadScene("Level1");
    }
    public void Nivel2()
    {
        SceneManager.LoadScene("Level2");
    }
    public void CargarMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Exit()
    {
        Application.Quit();
    }

}
