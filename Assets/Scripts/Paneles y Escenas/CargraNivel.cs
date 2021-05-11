using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CargraNivel : MonoBehaviour
{

    // cargar escenas
    public void CargarEscena(string Nombre) 
    {
        SceneManager.LoadScene(Nombre);
    }
    public void Salir() 
    {
        Application.Quit();
    }



    // cargar panel
    public GameObject panel;

    public void AbrirPanel()
    {
        if (panel != null)
        {
            bool isActive = panel.activeSelf;
            panel.SetActive(!isActive);
        }
    }


}