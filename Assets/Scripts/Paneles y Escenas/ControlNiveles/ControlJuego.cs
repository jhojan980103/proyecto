using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControlJuego : MonoBehaviour
{
    static public int NivelesDesbloqueados;
    public int NivelActual;
    public Button[] BotonesMenu;
    CargarYGuardar cargarYguardar;


    private void Awake()
    {
        cargarYguardar = GetComponent<CargarYGuardar>();
    }

    private void Start()
    {
        if (SceneManager.GetActiveScene().name == "MenuNiveles")
        {
            cargarYguardar.Guardar();
            ActualizarBotones();
        }
    }

    public void CambiarNivel(int nivel)
    {
        if (nivel == 0)
        {
            SceneManager.LoadScene("MenuNiveles");
        }
        else
        {
            SceneManager.LoadScene("DialogoJuego_" + nivel);
        }
    }

    public void DesbloquearNivel()
    {
        if (NivelesDesbloqueados < NivelActual)
        {
            NivelesDesbloqueados = NivelActual;
            NivelActual++;
        }
        VolverAlMenu();
    }

    void VolverAlMenu()
    {
        CambiarNivel(0);
    }

    public void ActualizarBotones()
    {
        for (int i = 0; i < NivelesDesbloqueados+1; i++)
        {
            BotonesMenu[i].interactable = true;
        }
    }
}
