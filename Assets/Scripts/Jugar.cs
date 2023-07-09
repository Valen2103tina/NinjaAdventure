using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jugar : MonoBehaviour
{
    // Start is called before the first frame update
    public void Juego()
    {
        SceneManager.LoadScene("Juego");
    }

    // Update is called once per frame
    public void Opciones()
    {
        SceneManager.LoadScene("Opciones");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Salir()
    {
        Application.Quit();
    }
}
