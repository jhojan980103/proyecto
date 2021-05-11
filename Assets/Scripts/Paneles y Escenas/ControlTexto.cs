using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ControlTexto : MonoBehaviour
{
    public Text DialogoTexto;
    
    public Queue<string> ColaDialogos;

    private void Start()
    {
        ColaDialogos = new Queue<string>();
    }

    public void ActivarAnimacion(Textos Textos)
    {
        Debug.Log("se inicio la conersacion" + Textos.ColaDialogos);

        ColaDialogos.Clear();

        foreach (string TextoGuardado in Textos.ColaDialogos)
        {
            ColaDialogos.Enqueue(TextoGuardado);
        }
        SiguienteTexto();
    }

    public void SiguienteTexto()
    {
        if (ColaDialogos.Count == 0)
        {
            FinalTexto();
            return;
        }

        string TextoGuardado = ColaDialogos.Dequeue();
        StopAllCoroutines();
        StartCoroutine(MostrarCaracter(TextoGuardado));
    }

    IEnumerator MostrarCaracter(string TextoGuardado)
    {
        DialogoTexto.text = "";
        foreach (var Caracter in TextoGuardado.ToCharArray())
        {
            DialogoTexto.text += Caracter;
            yield return new WaitForSeconds(0.1f);
        }
    }

    void FinalTexto()
    {
        Debug.Log("final Texto");
    }
}
