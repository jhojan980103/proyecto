using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextosTrigger : MonoBehaviour
{
    public Textos textos;

    public void TrigerTextos()
    {
        FindObjectOfType<ControlTexto>().ActivarAnimacion(textos);
    }
}
