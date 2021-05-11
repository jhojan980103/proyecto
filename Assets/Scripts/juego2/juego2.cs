using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class juego2 : MonoBehaviour
{

    public GameObject Letra1, Letra2, Letra3, Letra4, Caja1, Caja2, Caja3, Caja4;

    Vector3 LetraIni1, LetraIni2, LetraIni3, LetraIni4;

    string str = "";
    public string word;

    public GameObject questionToHide, questionToShow;

    bool Correcto1, Correcto2, Correcto3, Correcto4 = false;

    Vector3 IniEscalaLetra1, IniEscalaLetra2, IniEscalaLetra3, IniEscalaLetra4;


    public AudioSource source;
    public AudioClip[] correct;
    public AudioClip incorrect;
    public AudioClip buttonDrop;
    public AudioClip reload;

    void Start()
    {


        LetraIni1 = Letra1.transform.position;
        LetraIni2 = Letra2.transform.position;
        LetraIni3 = Letra3.transform.position;
        LetraIni4 = Letra4.transform.position;
 

        IniEscalaLetra1 = Letra1.transform.localScale;
        IniEscalaLetra2 = Letra2.transform.localScale;
        IniEscalaLetra3 = Letra3.transform.localScale;
        IniEscalaLetra4 = Letra4.transform.localScale;


    }



    public void DragLetra1()
    {
        Letra1.transform.position = Input.mousePosition;
    }
    public void DragLetra2()
    {
        Letra2.transform.position = Input.mousePosition;
    }
    public void DragLetra3()
    {
        Letra3.transform.position = Input.mousePosition;
    }
    public void DragLetra4()
    {
        Letra4.transform.position = Input.mousePosition;
    }




    public void DropLetra1()
    {
        float Distancia1 = Vector3.Distance(Letra1.transform.position, Caja1.transform.position);
        float Distancia2 = Vector3.Distance(Letra1.transform.position, Caja2.transform.position);
        float Distancia3 = Vector3.Distance(Letra1.transform.position, Caja3.transform.position);
        float Distancia4 = Vector3.Distance(Letra1.transform.position, Caja4.transform.position);


        if (Distancia1 < 50 && Correcto1 == false)
        {
            Letra1.transform.localScale = Caja1.transform.localScale;
            Letra1.transform.position = Caja1.transform.position;
            Correcto1 = true;
            Caja1.name = Letra1.name;
            source.clip = buttonDrop;
            source.Play();


        }
        else if (Distancia2 < 50 && Correcto2 == false)
        {
            Letra1.transform.localScale = Caja2.transform.localScale;
            Letra1.transform.position = Caja2.transform.position;
            Correcto2 = true;
            Caja2.name = Letra1.name;
            source.clip = buttonDrop;
            source.Play();

        }
        else if (Distancia3 < 50 && Correcto3 == false)
        {
            Letra1.transform.localScale = Caja3.transform.localScale;
            Letra1.transform.position = Caja3.transform.position;
            Correcto3 = true;
            Caja3.name = Letra1.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distancia4 < 50 && Correcto4 == false)
        {
            Letra1.transform.localScale = Caja4.transform.localScale;
            Letra1.transform.position = Caja4.transform.position;
            Correcto4 = true;
            Caja4.name = Letra1.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else
        {
            Letra1.transform.position = LetraIni1;
            source.clip = reload;
            source.Play();
        }

    }

    public void DropLetra2()
    {
        float Distancia1 = Vector3.Distance(Letra2.transform.position, Caja1.transform.position);
        float Distancia2 = Vector3.Distance(Letra2.transform.position, Caja2.transform.position);
        float Distancia3 = Vector3.Distance(Letra2.transform.position, Caja3.transform.position);
        float Distancia4 = Vector3.Distance(Letra2.transform.position, Caja4.transform.position);


        if (Distancia1 < 50 && Correcto1 == false)
        {
            Letra2.transform.localScale = Caja1.transform.localScale;
            Letra2.transform.position = Caja1.transform.position;
            Correcto1 = true;
            Caja1.name = Letra2.name;
            source.clip = buttonDrop;
            source.Play();


        }
        else if (Distancia2 < 50 && Correcto2 == false)
        {
            Letra2.transform.localScale = Caja2.transform.localScale;
            Letra2.transform.position = Caja2.transform.position;
            Correcto2 = true;
            Caja2.name = Letra2.name;
            source.clip = buttonDrop;
            source.Play();

        }
        else if (Distancia3 < 50 && Correcto3 == false)
        {
            Letra2.transform.localScale = Caja3.transform.localScale;
            Letra2.transform.position = Caja3.transform.position;
            Correcto3 = true;
            Caja3.name = Letra2.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distancia4 < 50 && Correcto4 == false)
        {
            Letra2.transform.localScale = Caja4.transform.localScale;
            Letra2.transform.position = Caja4.transform.position;
            Correcto4 = true;
            Caja4.name = Letra2.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else
        {
            Letra2.transform.position = LetraIni2;
            source.clip = reload;
            source.Play();
        }

    }

    public void DropLetra3()
    {
        float Distancia1 = Vector3.Distance(Letra3.transform.position, Caja1.transform.position);
        float Distancia2 = Vector3.Distance(Letra3.transform.position, Caja2.transform.position);
        float Distancia3 = Vector3.Distance(Letra3.transform.position, Caja3.transform.position);
        float Distancia4 = Vector3.Distance(Letra3.transform.position, Caja4.transform.position);


        if (Distancia1 < 50 && Correcto1 == false)
        {
            Letra3.transform.localScale = Caja1.transform.localScale;
            Letra3.transform.position = Caja1.transform.position;
            Correcto1 = true;
            Caja1.name = Letra3.name;
            source.clip = buttonDrop;
            source.Play();


        }
        else if (Distancia2 < 50 && Correcto2 == false)
        {
            Letra3.transform.localScale = Caja2.transform.localScale;
            Letra3.transform.position = Caja2.transform.position;
            Correcto2 = true;
            Caja2.name = Letra3.name;
            source.clip = buttonDrop;
            source.Play();

        }
        else if (Distancia3 < 50 && Correcto3 == false)
        {
            Letra3.transform.localScale = Caja3.transform.localScale;
            Letra3.transform.position = Caja3.transform.position;
            Correcto3 = true;
            Caja3.name = Letra3.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distancia4 < 50 && Correcto4 == false)
        {
            Letra3.transform.localScale = Caja4.transform.localScale;
            Letra3.transform.position = Caja4.transform.position;
            Correcto4 = true;
            Caja4.name = Letra3.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else
        {
            Letra3.transform.position = LetraIni3;
            source.clip = reload;
            source.Play();
        }

    }

    public void DropLetra4()
    {
        float Distancia1 = Vector3.Distance(Letra4.transform.position, Caja1.transform.position);
        float Distancia2 = Vector3.Distance(Letra4.transform.position, Caja2.transform.position);
        float Distancia3 = Vector3.Distance(Letra4.transform.position, Caja3.transform.position);
        float Distancia4 = Vector3.Distance(Letra4.transform.position, Caja4.transform.position);


        if (Distancia1 < 50 && Correcto1 == false)
        {
            Letra4.transform.localScale = Caja1.transform.localScale;
            Letra4.transform.position = Caja1.transform.position;
            Correcto1 = true;
            Caja1.name = Letra4.name;
            source.clip = buttonDrop;
            source.Play();


        }
        else if (Distancia2 < 50 && Correcto2 == false)
        {
            Letra4.transform.localScale = Caja2.transform.localScale;
            Letra4.transform.position = Caja2.transform.position;
            Correcto2 = true;
            Caja2.name = Letra4.name;
            source.clip = buttonDrop;
            source.Play();

        }
        else if (Distancia3 < 50 && Correcto3 == false)
        {
            Letra4.transform.localScale = Caja3.transform.localScale;
            Letra4.transform.position = Caja3.transform.position;
            Correcto3 = true;
            Caja3.name = Letra4.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distancia4 < 50 && Correcto4 == false)
        {
            Letra4.transform.localScale = Caja4.transform.localScale;
            Letra4.transform.position = Caja4.transform.position;
            Correcto4 = true;
            Caja4.name = Letra4.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else
        {
            Letra4.transform.position = LetraIni4;
            source.clip = reload;
            source.Play();
        }

    }



    public void Check()
    {


        str = Caja1.name + Caja2.name + Caja3.name + Caja4.name;

        if (word == str)
        {

            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
            StartCoroutine(LoadNextPanel());

        }
        else
        {
            source.clip = incorrect;
            source.Play();

        }

    }

    public void Reload()
    {
        str = "";

        source.clip = reload;
        source.Play();

        Correcto1 = false;
        Correcto2 = false;
        Correcto3 = false;
        Correcto4 = false;


        Caja1.name = "1";
        Caja2.name = "2";
        Caja3.name = "3";
        Caja4.name = "4";


        Letra1.transform.position = LetraIni1;
        Letra2.transform.position = LetraIni2;
        Letra3.transform.position = LetraIni3;
        Letra4.transform.position = LetraIni4;


        Letra1.transform.localScale = IniEscalaLetra1;
        Letra2.transform.localScale = IniEscalaLetra2;
        Letra3.transform.localScale = IniEscalaLetra3;
        Letra4.transform.localScale = IniEscalaLetra4;


    }

    IEnumerator LoadNextPanel()
    {
        yield return new WaitForSeconds(3f);
        questionToHide.SetActive(false);
        questionToShow.SetActive(true);
    }

}
