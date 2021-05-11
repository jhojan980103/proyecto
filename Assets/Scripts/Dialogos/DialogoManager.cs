using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogoManager : MonoBehaviour
{
    public Text nombretexto;
    public Text dialogotexto;

    public Animator animator; 

    public Queue<string> oraciones;

    private void Start()
    {
        oraciones = new Queue<string>();
    }

    public void StartDialogo(Dialogos dialogo)
    {
        animator.SetBool("Abierto", true);

        nombretexto.text = dialogo.nombre;

        oraciones.Clear();

        foreach (string oracion in dialogo.oraciones)
        {
            oraciones.Enqueue(oracion);
        }

        SiguienteOracion();
    }

    public void SiguienteOracion()
    {
        if (oraciones.Count == 0)
        {
            FinalDialogo();
            return;
        }

        string oracion = oraciones.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TipoOracion(oracion));
    }

    IEnumerator TipoOracion(string oracion)
    {
        dialogotexto.text = "";

        foreach (char letra in oracion.ToCharArray())
        {
            dialogotexto.text += letra;
            yield return new WaitForSeconds(0.1f);
        }
    }

    void FinalDialogo()
    {
        animator.SetBool("Abierto", false);
    }
}
