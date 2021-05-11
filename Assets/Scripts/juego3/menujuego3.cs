using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menujuego3 : MonoBehaviour
{
    public void Jugar(int Nivel)
    {
        PlayerPrefs.SetInt("Nivel", Nivel);
        SceneManager.LoadScene("juego3");
    }
    public void RedesSociales(string URL)
    {
        Application.OpenURL(URL);
    }
}
