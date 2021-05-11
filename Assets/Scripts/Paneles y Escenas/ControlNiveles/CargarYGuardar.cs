using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class CargarYGuardar : MonoBehaviour
{
    private string RutaArchivo;
    static bool PrimeraVez = true;



    private void Awake()
    {
        RutaArchivo = Application.persistentDataPath + "/Niveles.dat";
        if (PrimeraVez)
        {
            Cargar();
            PrimeraVez = false;
        }
    }

    public void Guardar()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(RutaArchivo);
        DatosAGuardar datos = new DatosAGuardar(ControlJuego.NivelesDesbloqueados);
        bf.Serialize(file, datos);
        file.Close();
    }

    public void Cargar()
    {
        if (File.Exists(RutaArchivo))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(RutaArchivo, FileMode.Open);
            DatosAGuardar datos = (DatosAGuardar)bf.Deserialize(file);
            ControlJuego.NivelesDesbloqueados = datos.nivelesdesbloqueados;
        }
        else
        {
            ControlJuego.NivelesDesbloqueados = 0;
        }
    }
}


[System.Serializable]
class DatosAGuardar
{
    public int nivelesdesbloqueados;

    public DatosAGuardar(int nivelesdesbloqueados_)
    {
        nivelesdesbloqueados = nivelesdesbloqueados_;
    }
}
