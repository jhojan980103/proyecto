using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonPausa : MonoBehaviour
{
    
    public static bool gamepanel;
    public static bool seguropanel;

    public GameObject panelpausa, seguro;

    private void Start()
    {
        panelpausa.SetActive(false);
        seguro.SetActive(false);
    }

    public void SwitchPause()
    {
        if (gamepanel)
        {
            btnContinuar();
        }
        else
        {
            btnPausa();
        }
    }

    void btnContinuar()
    {
        panelpausa.SetActive(false);
        Time.timeScale = 1;
        gamepanel = false;
    }

    void btnPausa()
    {
        panelpausa.SetActive(true);
        Time.timeScale = 0;
        gamepanel = true;
    }


    public void MenuPrincipal(string nombre)
    {
        SceneManager.LoadScene(nombre);
    }


    public void PanelSeguroCerrar()
    {
        seguro.SetActive(true);
    }


    public void BotonNo()
    {
        seguro.SetActive(false);
    }

    public void BotonSi()
    {
        Debug.Log("Se ha salido del juego");
        Application.Quit();
    }
}
