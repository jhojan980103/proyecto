using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlPuntuacion : MonoBehaviour
{
    public Text TextoPuntuacion;
    int Puntuacion = 0;
    ControlJuego controljuego;

    private void Awake()
    {
        controljuego = GameObject.Find("ControlJuego").GetComponent(typeof(ControlJuego)) as ControlJuego;
    }

    public void SumarPuntos()
    {
        Puntuacion++;
        ActualizarTextoPuntuacion();

        if (Puntuacion >= 1)
        {
            controljuego.DesbloquearNivel();
        }
    }

    void ActualizarTextoPuntuacion() 
    {
        TextoPuntuacion.text = "Puntuacion: " + Puntuacion.ToString();
    }
}
