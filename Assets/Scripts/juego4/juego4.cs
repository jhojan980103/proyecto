using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class juego4 : MonoBehaviour
{
    public GameObject Letra1, Letra2, Letra3, Letra4, Letra5, Letra6, Caja1, Caja2, Caja3, Caja4, Caja5, Caja6;

    Vector3 LetraIni1, LetraIni2, LetraIni3, LetraIni4, LetraIni5, LetraIni6;

    string str = "";
    public string word;

    public GameObject questionToHide, questionToShow;

    bool Correcto1, Correcto2, Correcto3, Correcto4, Correcto5, Correcto6;

    Vector3 IniEscalaLetra1, IniEscalaLetra2, IniEscalaLetra3, IniEscalaLetra4, IniEscalaLetra5, IniEscalaLetra6;


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
        LetraIni5 = Letra5.transform.position;
        LetraIni6 = Letra6.transform.position;


        IniEscalaLetra1 = Letra1.transform.localScale;
        IniEscalaLetra2 = Letra2.transform.localScale;
        IniEscalaLetra3 = Letra3.transform.localScale;
        IniEscalaLetra4 = Letra4.transform.localScale;
        IniEscalaLetra5 = Letra5.transform.localScale;
        IniEscalaLetra6 = Letra6.transform.localScale;



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
    public void DragLetra5()
    {
        Letra5.transform.position = Input.mousePosition;
    }
    public void DragLetra6()
    {
        Letra6.transform.position = Input.mousePosition;
    }
   






    public void DropLetra1()
    {
        float Distancia1 = Vector3.Distance(Letra1.transform.position, Caja1.transform.position);
        float Distancia2 = Vector3.Distance(Letra1.transform.position, Caja2.transform.position);
        float Distancia3 = Vector3.Distance(Letra1.transform.position, Caja3.transform.position);
        float Distancia4 = Vector3.Distance(Letra1.transform.position, Caja4.transform.position);
        float Distancia5 = Vector3.Distance(Letra1.transform.position, Caja5.transform.position);
        float Distancia6 = Vector3.Distance(Letra1.transform.position, Caja6.transform.position);


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

        else if (Distancia5 < 50 && Correcto5 == false)
        {
            Letra1.transform.localScale = Caja5.transform.localScale;
            Letra1.transform.position = Caja5.transform.position;
            Correcto5 = true;
            Caja5.name = Letra1.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia6 < 50 && Correcto6 == false)
        {
            Letra1.transform.localScale = Caja6.transform.localScale;
            Letra1.transform.position = Caja6.transform.position;
            Correcto6 = true;
            Caja6.name = Letra1.name;
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
        float Distancia5 = Vector3.Distance(Letra2.transform.position, Caja5.transform.position);
        float Distancia6 = Vector3.Distance(Letra2.transform.position, Caja6.transform.position);


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

        else if (Distancia5 < 50 && Correcto5 == false)
        {
            Letra2.transform.localScale = Caja5.transform.localScale;
            Letra2.transform.position = Caja5.transform.position;
            Correcto5 = true;
            Caja5.name = Letra2.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia6 < 50 && Correcto6 == false)
        {
            Letra2.transform.localScale = Caja6.transform.localScale;
            Letra2.transform.position = Caja6.transform.position;
            Correcto6 = true;
            Caja6.name = Letra2.name;
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
        float Distancia5 = Vector3.Distance(Letra3.transform.position, Caja5.transform.position);
        float Distancia6 = Vector3.Distance(Letra3.transform.position, Caja6.transform.position);


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

        else if (Distancia5 < 50 && Correcto5 == false)
        {
            Letra3.transform.localScale = Caja5.transform.localScale;
            Letra3.transform.position = Caja5.transform.position;
            Correcto5 = true;
            Caja5.name = Letra3.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia6 < 50 && Correcto6 == false)
        {
            Letra3.transform.localScale = Caja6.transform.localScale;
            Letra3.transform.position = Caja6.transform.position;
            Correcto6 = true;
            Caja6.name = Letra3.name;
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
        float Distancia5 = Vector3.Distance(Letra4.transform.position, Caja5.transform.position);
        float Distancia6 = Vector3.Distance(Letra4.transform.position, Caja6.transform.position);


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

        else if (Distancia5 < 50 && Correcto5 == false)
        {
            Letra4.transform.localScale = Caja5.transform.localScale;
            Letra4.transform.position = Caja5.transform.position;
            Correcto5 = true;
            Caja5.name = Letra4.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia6 < 50 && Correcto6 == false)
        {
            Letra4.transform.localScale = Caja6.transform.localScale;
            Letra4.transform.position = Caja6.transform.position;
            Correcto6 = true;
            Caja6.name = Letra4.name;
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

    public void DropLetra5()
    {
        float Distancia1 = Vector3.Distance(Letra5.transform.position, Caja1.transform.position);
        float Distancia2 = Vector3.Distance(Letra5.transform.position, Caja2.transform.position);
        float Distancia3 = Vector3.Distance(Letra5.transform.position, Caja3.transform.position);
        float Distancia4 = Vector3.Distance(Letra5.transform.position, Caja4.transform.position);
        float Distancia5 = Vector3.Distance(Letra5.transform.position, Caja5.transform.position);
        float Distancia6 = Vector3.Distance(Letra5.transform.position, Caja6.transform.position);


        if (Distancia1 < 50 && Correcto1 == false)
        {
            Letra5.transform.localScale = Caja1.transform.localScale;
            Letra5.transform.position = Caja1.transform.position;
            Correcto1 = true;
            Caja1.name = Letra5.name;
            source.clip = buttonDrop;
            source.Play();


        }
        else if (Distancia2 < 50 && Correcto2 == false)
        {
            Letra5.transform.localScale = Caja2.transform.localScale;
            Letra5.transform.position = Caja2.transform.position;
            Correcto2 = true;
            Caja2.name = Letra5.name;
            source.clip = buttonDrop;
            source.Play();

        }
        else if (Distancia3 < 50 && Correcto3 == false)
        {
            Letra5.transform.localScale = Caja3.transform.localScale;
            Letra5.transform.position = Caja3.transform.position;
            Correcto3 = true;
            Caja3.name = Letra5.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distancia4 < 50 && Correcto4 == false)
        {
            Letra5.transform.localScale = Caja4.transform.localScale;
            Letra5.transform.position = Caja4.transform.position;
            Correcto4 = true;
            Caja4.name = Letra5.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia5 < 50 && Correcto5 == false)
        {
            Letra5.transform.localScale = Caja5.transform.localScale;
            Letra5.transform.position = Caja5.transform.position;
            Correcto5 = true;
            Caja5.name = Letra5.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia6 < 50 && Correcto6 == false)
        {
            Letra5.transform.localScale = Caja6.transform.localScale;
            Letra5.transform.position = Caja6.transform.position;
            Correcto6 = true;
            Caja6.name = Letra5.name;
            source.clip = buttonDrop;
            source.Play();
        }


        else
        {
            Letra5.transform.position = LetraIni5;
            source.clip = reload;
            source.Play();
        }

    }

    public void DropLetra6()
    {
        float Distancia1 = Vector3.Distance(Letra6.transform.position, Caja1.transform.position);
        float Distancia2 = Vector3.Distance(Letra6.transform.position, Caja2.transform.position);
        float Distancia3 = Vector3.Distance(Letra6.transform.position, Caja3.transform.position);
        float Distancia4 = Vector3.Distance(Letra6.transform.position, Caja4.transform.position);
        float Distancia5 = Vector3.Distance(Letra6.transform.position, Caja5.transform.position);
        float Distancia6 = Vector3.Distance(Letra6.transform.position, Caja6.transform.position);


        if (Distancia1 < 50 && Correcto1 == false)
        {
            Letra6.transform.localScale = Caja1.transform.localScale;
            Letra6.transform.position = Caja1.transform.position;
            Correcto1 = true;
            Caja1.name = Letra6.name;
            source.clip = buttonDrop;
            source.Play();


        }
        else if (Distancia2 < 50 && Correcto2 == false)
        {
            Letra6.transform.localScale = Caja2.transform.localScale;
            Letra6.transform.position = Caja2.transform.position;
            Correcto2 = true;
            Caja2.name = Letra6.name;
            source.clip = buttonDrop;
            source.Play();

        }
        else if (Distancia3 < 50 && Correcto3 == false)
        {
            Letra6.transform.localScale = Caja3.transform.localScale;
            Letra6.transform.position = Caja3.transform.position;
            Correcto3 = true;
            Caja3.name = Letra6.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distancia4 < 50 && Correcto4 == false)
        {
            Letra6.transform.localScale = Caja4.transform.localScale;
            Letra6.transform.position = Caja4.transform.position;
            Correcto4 = true;
            Caja4.name = Letra6.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia5 < 50 && Correcto5 == false)
        {
            Letra6.transform.localScale = Caja5.transform.localScale;
            Letra6.transform.position = Caja5.transform.position;
            Correcto5 = true;
            Caja5.name = Letra6.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia6 < 50 && Correcto6 == false)
        {
            Letra6.transform.localScale = Caja6.transform.localScale;
            Letra6.transform.position = Caja6.transform.position;
            Correcto6 = true;
            Caja6.name = Letra6.name;
            source.clip = buttonDrop;
            source.Play();
        }

       
        else
        {
            Letra6.transform.position = LetraIni6;
            source.clip = reload;
            source.Play();
        }

    }







    public void Check()
    {


        str = Caja1.name + Caja2.name + Caja3.name + Caja4.name + Caja5.name + Caja6.name;

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
        Correcto5 = false;
        Correcto6 = false;


        Caja1.name = "1";
        Caja2.name = "2";
        Caja3.name = "3";
        Caja4.name = "4";
        Caja5.name = "5";
        Caja6.name = "6";



        Letra1.transform.position = LetraIni1;
        Letra2.transform.position = LetraIni2;
        Letra3.transform.position = LetraIni3;
        Letra4.transform.position = LetraIni4;
        Letra5.transform.position = LetraIni5;
        Letra6.transform.position = LetraIni6;


        Letra1.transform.localScale = IniEscalaLetra1;
        Letra2.transform.localScale = IniEscalaLetra2;
        Letra3.transform.localScale = IniEscalaLetra3;
        Letra4.transform.localScale = IniEscalaLetra4;
        Letra5.transform.localScale = IniEscalaLetra5;
        Letra6.transform.localScale = IniEscalaLetra6;


    }

    IEnumerator LoadNextPanel()
    {
        yield return new WaitForSeconds(3f);
        questionToHide.SetActive(false);
        questionToShow.SetActive(true);
    }

}
