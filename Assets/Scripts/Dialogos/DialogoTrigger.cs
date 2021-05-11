using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogoTrigger : MonoBehaviour
{
    public Dialogos dialogo;

    public void TriggerDialogo()
    {
        FindObjectOfType<DialogoManager>().StartDialogo(dialogo);
    }
}
