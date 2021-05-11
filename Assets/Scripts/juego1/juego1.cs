using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class juego1 : MonoBehaviour
{

    public GameObject Letra1, Letra2, Letra3, Letra4, Letra5, Letra6, Letra7, Letra8, Letra9, Letra10, Letra11, Letra12, Letra13, Letra14, Letra15, Letra16, Caja1, Caja2, Caja3, Caja4, Caja5, Caja6, Caja7, Caja8, Caja9, Caja10, Caja11, Caja12, Caja13, Caja14, Caja15, Caja16;

    Vector3 LetraIni1, LetraIni2, LetraIni3, LetraIni4, LetraIni5, LetraIni6, LetraIni7, LetraIni8, LetraIni9, LetraIni10, LetraIni11, LetraIni12, LetraIni13, LetraIni14, LetraIni15, LetraIni16;

    string str = "";
    public string word;

    public GameObject questionToHide, questionToShow;

    bool Correcto1, Correcto2, Correcto3, Correcto4, Correcto5, Correcto6, Correcto7, Correcto8, Correcto9, Correcto10, Correcto11, Correcto12, Correcto13, Correcto14, Correcto15, Correcto16 = false;

    Vector3 IniEscalaLetra1, IniEscalaLetra2, IniEscalaLetra3, IniEscalaLetra4, IniEscalaLetra5, IniEscalaLetra6, IniEscalaLetra7, IniEscalaLetra8, IniEscalaLetra9, IniEscalaLetra10, IniEscalaLetra11, IniEscalaLetra12, IniEscalaLetra13, IniEscalaLetra14, IniEscalaLetra15, IniEscalaLetra16; 
            

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
        LetraIni7 = Letra7.transform.position;
        LetraIni8 = Letra8.transform.position;
        LetraIni9 = Letra9.transform.position;
        LetraIni10 = Letra10.transform.position;
        LetraIni11 = Letra11.transform.position;
        LetraIni12 = Letra12.transform.position;
        LetraIni13 = Letra13.transform.position;
        LetraIni14 = Letra14.transform.position;
        LetraIni15 = Letra15.transform.position;
        LetraIni16 = Letra16.transform.position;

        IniEscalaLetra1 = Letra1.transform.localScale;
        IniEscalaLetra2 = Letra2.transform.localScale;
        IniEscalaLetra3 = Letra3.transform.localScale;
        IniEscalaLetra4 = Letra4.transform.localScale;
        IniEscalaLetra5 = Letra5.transform.localScale;
        IniEscalaLetra6 = Letra6.transform.localScale;
        IniEscalaLetra7 = Letra7.transform.localScale;
        IniEscalaLetra8 = Letra8.transform.localScale;
        IniEscalaLetra9 = Letra9.transform.localScale;
        IniEscalaLetra10 = Letra10.transform.localScale;
        IniEscalaLetra11 = Letra11.transform.localScale;
        IniEscalaLetra12 = Letra12.transform.localScale;
        IniEscalaLetra13 = Letra13.transform.localScale;
        IniEscalaLetra14 = Letra14.transform.localScale;
        IniEscalaLetra15 = Letra15.transform.localScale;
        IniEscalaLetra16 = Letra16.transform.localScale;


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
    public void DragLetra7()
    {
        Letra7.transform.position = Input.mousePosition;
    }
    public void DragLetra8()
    {
        Letra8.transform.position = Input.mousePosition;
    }
    public void DragLetra9()
    {
        Letra9.transform.position = Input.mousePosition;
    }
    public void DragLetra10()
    {
        Letra10.transform.position = Input.mousePosition;
    }
    public void DragLetra11()
    {
        Letra11.transform.position = Input.mousePosition;
    }
    public void DragLetra12()
    {
        Letra12.transform.position = Input.mousePosition;
    }
    public void DragLetra13()
    {
        Letra13.transform.position = Input.mousePosition;
    }
    public void DragLetra14()
    {
        Letra14.transform.position = Input.mousePosition;
    }
    public void DragLetra15()
    {
        Letra15.transform.position = Input.mousePosition;
    }
    public void DragLetra16()
    {
        Letra16.transform.position = Input.mousePosition;
    }
 





    public void DropLetra1()
    {
        float Distancia1 = Vector3.Distance(Letra1.transform.position, Caja1.transform.position);
        float Distancia2 = Vector3.Distance(Letra1.transform.position, Caja2.transform.position);
        float Distancia3 = Vector3.Distance(Letra1.transform.position, Caja3.transform.position);
        float Distancia4 = Vector3.Distance(Letra1.transform.position, Caja4.transform.position);
        float Distancia5 = Vector3.Distance(Letra1.transform.position, Caja5.transform.position);
        float Distancia6 = Vector3.Distance(Letra1.transform.position, Caja6.transform.position);
        float Distancia7 = Vector3.Distance(Letra1.transform.position, Caja7.transform.position);
        float Distancia8 = Vector3.Distance(Letra1.transform.position, Caja8.transform.position);
        float Distancia9 = Vector3.Distance(Letra1.transform.position, Caja9.transform.position);
        float Distancia10 = Vector3.Distance(Letra1.transform.position, Caja10.transform.position);
        float Distancia11 = Vector3.Distance(Letra1.transform.position, Caja11.transform.position);
        float Distancia12 = Vector3.Distance(Letra1.transform.position, Caja12.transform.position);
        float Distancia13 = Vector3.Distance(Letra1.transform.position, Caja13.transform.position);
        float Distancia14 = Vector3.Distance(Letra1.transform.position, Caja14.transform.position);
        float Distancia15 = Vector3.Distance(Letra1.transform.position, Caja15.transform.position);
        float Distancia16 = Vector3.Distance(Letra1.transform.position, Caja16.transform.position);

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

        else if (Distancia7 < 50 && Correcto7 == false)
        {
            Letra1.transform.localScale = Caja7.transform.localScale;
            Letra1.transform.position = Caja7.transform.position;
            Correcto7 = true;
            Caja7.name = Letra1.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia8 < 50 && Correcto8 == false)
        {
            Letra1.transform.localScale = Caja8.transform.localScale;
            Letra1.transform.position = Caja8.transform.position;
            Correcto8 = true;
            Caja8.name = Letra1.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia9 < 50 && Correcto9 == false)
        {
            Letra1.transform.localScale = Caja9.transform.localScale;
            Letra1.transform.position = Caja9.transform.position;
            Correcto9 = true;
            Caja9.name = Letra1.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia10 < 50 && Correcto10 == false)
        {
            Letra1.transform.localScale = Caja10.transform.localScale;
            Letra1.transform.position = Caja10.transform.position;
            Correcto10 = true;
            Caja10.name = Letra1.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia11 < 50 && Correcto11 == false)
        {
            Letra1.transform.localScale = Caja11.transform.localScale;
            Letra1.transform.position = Caja11.transform.position;
            Correcto11 = true;
            Caja11.name = Letra1.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia12 < 50 && Correcto12 == false)
        {
            Letra1.transform.localScale = Caja12.transform.localScale;
            Letra1.transform.position = Caja12.transform.position;
            Correcto12 = true;
            Caja12.name = Letra1.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia13 < 50 && Correcto13 == false)
        {
            Letra1.transform.localScale = Caja13.transform.localScale;
            Letra1.transform.position = Caja13.transform.position;
            Correcto13 = true;
            Caja13.name = Letra1.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia14 < 50 && Correcto14 == false)
        {
            Letra1.transform.localScale = Caja14.transform.localScale;
            Letra1.transform.position = Caja14.transform.position;
            Correcto14 = true;
            Caja14.name = Letra1.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia15 < 50 && Correcto15 == false)
        {
            Letra1.transform.localScale = Caja15.transform.localScale;
            Letra1.transform.position = Caja15.transform.position;
            Correcto15 = true;
            Caja15.name = Letra1.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia16 < 50 && Correcto16 == false)
        {
            Letra1.transform.localScale = Caja16.transform.localScale;
            Letra1.transform.position = Caja16.transform.position;
            Correcto16 = true;
            Caja16.name = Letra1.name;
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
        float Distancia7 = Vector3.Distance(Letra2.transform.position, Caja7.transform.position);
        float Distancia8 = Vector3.Distance(Letra2.transform.position, Caja8.transform.position);
        float Distancia9 = Vector3.Distance(Letra2.transform.position, Caja9.transform.position);
        float Distancia10 = Vector3.Distance(Letra2.transform.position, Caja10.transform.position);
        float Distancia11 = Vector3.Distance(Letra2.transform.position, Caja11.transform.position);
        float Distancia12 = Vector3.Distance(Letra2.transform.position, Caja12.transform.position);
        float Distancia13 = Vector3.Distance(Letra2.transform.position, Caja13.transform.position);
        float Distancia14 = Vector3.Distance(Letra2.transform.position, Caja14.transform.position);
        float Distancia15 = Vector3.Distance(Letra2.transform.position, Caja15.transform.position);
        float Distancia16 = Vector3.Distance(Letra2.transform.position, Caja16.transform.position);

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

        else if (Distancia7 < 50 && Correcto7 == false)
        {
            Letra2.transform.localScale = Caja7.transform.localScale;
            Letra2.transform.position = Caja7.transform.position;
            Correcto7 = true;
            Caja7.name = Letra2.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia8 < 50 && Correcto8 == false)
        {
            Letra2.transform.localScale = Caja8.transform.localScale;
            Letra2.transform.position = Caja8.transform.position;
            Correcto8 = true;
            Caja8.name = Letra2.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia9 < 50 && Correcto9 == false)
        {
            Letra2.transform.localScale = Caja9.transform.localScale;
            Letra2.transform.position = Caja9.transform.position;
            Correcto9 = true;
            Caja9.name = Letra2.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia10 < 50 && Correcto10 == false)
        {
            Letra2.transform.localScale = Caja10.transform.localScale;
            Letra2.transform.position = Caja10.transform.position;
            Correcto10 = true;
            Caja10.name = Letra2.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia11 < 50 && Correcto11 == false)
        {
            Letra2.transform.localScale = Caja11.transform.localScale;
            Letra2.transform.position = Caja11.transform.position;
            Correcto11 = true;
            Caja11.name = Letra2.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia12 < 50 && Correcto12 == false)
        {
            Letra2.transform.localScale = Caja12.transform.localScale;
            Letra2.transform.position = Caja12.transform.position;
            Correcto12 = true;
            Caja12.name = Letra2.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia13 < 50 && Correcto13 == false)
        {
            Letra2.transform.localScale = Caja13.transform.localScale;
            Letra2.transform.position = Caja13.transform.position;
            Correcto13 = true;
            Caja13.name = Letra2.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia14 < 50 && Correcto14 == false)
        {
            Letra2.transform.localScale = Caja14.transform.localScale;
            Letra2.transform.position = Caja14.transform.position;
            Correcto14 = true;
            Caja14.name = Letra2.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia15 < 50 && Correcto15 == false)
        {
            Letra2.transform.localScale = Caja15.transform.localScale;
            Letra2.transform.position = Caja15.transform.position;
            Correcto15 = true;
            Caja15.name = Letra2.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia16 < 50 && Correcto16 == false)
        {
            Letra2.transform.localScale = Caja16.transform.localScale;
            Letra2.transform.position = Caja16.transform.position;
            Correcto16 = true;
            Caja16.name = Letra2.name;
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
        float Distancia7 = Vector3.Distance(Letra3.transform.position, Caja7.transform.position);
        float Distancia8 = Vector3.Distance(Letra3.transform.position, Caja8.transform.position);
        float Distancia9 = Vector3.Distance(Letra3.transform.position, Caja9.transform.position);
        float Distancia10 = Vector3.Distance(Letra3.transform.position, Caja10.transform.position);
        float Distancia11 = Vector3.Distance(Letra3.transform.position, Caja11.transform.position);
        float Distancia12 = Vector3.Distance(Letra3.transform.position, Caja12.transform.position);
        float Distancia13 = Vector3.Distance(Letra3.transform.position, Caja13.transform.position);
        float Distancia14 = Vector3.Distance(Letra3.transform.position, Caja14.transform.position);
        float Distancia15 = Vector3.Distance(Letra3.transform.position, Caja15.transform.position);
        float Distancia16 = Vector3.Distance(Letra3.transform.position, Caja16.transform.position);

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

        else if (Distancia7 < 50 && Correcto7 == false)
        {
            Letra3.transform.localScale = Caja7.transform.localScale;
            Letra3.transform.position = Caja7.transform.position;
            Correcto7 = true;
            Caja7.name = Letra3.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia8 < 50 && Correcto8 == false)
        {
            Letra3.transform.localScale = Caja8.transform.localScale;
            Letra3.transform.position = Caja8.transform.position;
            Correcto8 = true;
            Caja8.name = Letra3.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia9 < 50 && Correcto9 == false)
        {
            Letra3.transform.localScale = Caja9.transform.localScale;
            Letra3.transform.position = Caja9.transform.position;
            Correcto9 = true;
            Caja9.name = Letra3.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia10 < 50 && Correcto10 == false)
        {
            Letra3.transform.localScale = Caja10.transform.localScale;
            Letra3.transform.position = Caja10.transform.position;
            Correcto10 = true;
            Caja10.name = Letra3.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia11 < 50 && Correcto11 == false)
        {
            Letra3.transform.localScale = Caja11.transform.localScale;
            Letra3.transform.position = Caja11.transform.position;
            Correcto11 = true;
            Caja11.name = Letra3.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia12 < 50 && Correcto12 == false)
        {
            Letra3.transform.localScale = Caja12.transform.localScale;
            Letra3.transform.position = Caja12.transform.position;
            Correcto12 = true;
            Caja12.name = Letra3.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia13 < 50 && Correcto13 == false)
        {
            Letra3.transform.localScale = Caja13.transform.localScale;
            Letra3.transform.position = Caja13.transform.position;
            Correcto13 = true;
            Caja13.name = Letra3.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia14 < 50 && Correcto14 == false)
        {
            Letra3.transform.localScale = Caja14.transform.localScale;
            Letra3.transform.position = Caja14.transform.position;
            Correcto14 = true;
            Caja14.name = Letra3.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia15 < 50 && Correcto15 == false)
        {
            Letra3.transform.localScale = Caja15.transform.localScale;
            Letra3.transform.position = Caja15.transform.position;
            Correcto15 = true;
            Caja15.name = Letra3.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia16 < 50 && Correcto16 == false)
        {
            Letra3.transform.localScale = Caja16.transform.localScale;
            Letra3.transform.position = Caja16.transform.position;
            Correcto16 = true;
            Caja16.name = Letra3.name;
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
        float Distancia7 = Vector3.Distance(Letra4.transform.position, Caja7.transform.position);
        float Distancia8 = Vector3.Distance(Letra4.transform.position, Caja8.transform.position);
        float Distancia9 = Vector3.Distance(Letra4.transform.position, Caja9.transform.position);
        float Distancia10 = Vector3.Distance(Letra4.transform.position, Caja10.transform.position);
        float Distancia11 = Vector3.Distance(Letra4.transform.position, Caja11.transform.position);
        float Distancia12 = Vector3.Distance(Letra4.transform.position, Caja12.transform.position);
        float Distancia13 = Vector3.Distance(Letra4.transform.position, Caja13.transform.position);
        float Distancia14 = Vector3.Distance(Letra4.transform.position, Caja14.transform.position);
        float Distancia15 = Vector3.Distance(Letra4.transform.position, Caja15.transform.position);
        float Distancia16 = Vector3.Distance(Letra4.transform.position, Caja16.transform.position);

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

        else if (Distancia7 < 50 && Correcto7 == false)
        {
            Letra4.transform.localScale = Caja7.transform.localScale;
            Letra4.transform.position = Caja7.transform.position;
            Correcto7 = true;
            Caja7.name = Letra4.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia8 < 50 && Correcto8 == false)
        {
            Letra4.transform.localScale = Caja8.transform.localScale;
            Letra4.transform.position = Caja8.transform.position;
            Correcto8 = true;
            Caja8.name = Letra4.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia9 < 50 && Correcto9 == false)
        {
            Letra4.transform.localScale = Caja9.transform.localScale;
            Letra4.transform.position = Caja9.transform.position;
            Correcto9 = true;
            Caja9.name = Letra4.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia10 < 50 && Correcto10 == false)
        {
            Letra4.transform.localScale = Caja10.transform.localScale;
            Letra4.transform.position = Caja10.transform.position;
            Correcto10 = true;
            Caja10.name = Letra4.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia11 < 50 && Correcto11 == false)
        {
            Letra4.transform.localScale = Caja11.transform.localScale;
            Letra4.transform.position = Caja11.transform.position;
            Correcto11 = true;
            Caja11.name = Letra4.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia12 < 50 && Correcto12 == false)
        {
            Letra4.transform.localScale = Caja12.transform.localScale;
            Letra4.transform.position = Caja12.transform.position;
            Correcto12 = true;
            Caja12.name = Letra4.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia13 < 50 && Correcto13 == false)
        {
            Letra4.transform.localScale = Caja13.transform.localScale;
            Letra4.transform.position = Caja13.transform.position;
            Correcto13 = true;
            Caja13.name = Letra4.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia14 < 50 && Correcto14 == false)
        {
            Letra4.transform.localScale = Caja14.transform.localScale;
            Letra4.transform.position = Caja14.transform.position;
            Correcto14 = true;
            Caja14.name = Letra4.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia15 < 50 && Correcto15 == false)
        {
            Letra4.transform.localScale = Caja15.transform.localScale;
            Letra4.transform.position = Caja15.transform.position;
            Correcto15 = true;
            Caja15.name = Letra4.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia16 < 50 && Correcto16 == false)
        {
            Letra4.transform.localScale = Caja16.transform.localScale;
            Letra4.transform.position = Caja16.transform.position;
            Correcto16 = true;
            Caja16.name = Letra4.name;
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
        float Distancia7 = Vector3.Distance(Letra5.transform.position, Caja7.transform.position);
        float Distancia8 = Vector3.Distance(Letra5.transform.position, Caja8.transform.position);
        float Distancia9 = Vector3.Distance(Letra5.transform.position, Caja9.transform.position);
        float Distancia10 = Vector3.Distance(Letra5.transform.position, Caja10.transform.position);
        float Distancia11 = Vector3.Distance(Letra5.transform.position, Caja11.transform.position);
        float Distancia12 = Vector3.Distance(Letra5.transform.position, Caja12.transform.position);
        float Distancia13 = Vector3.Distance(Letra5.transform.position, Caja13.transform.position);
        float Distancia14 = Vector3.Distance(Letra5.transform.position, Caja14.transform.position);
        float Distancia15 = Vector3.Distance(Letra5.transform.position, Caja15.transform.position);
        float Distancia16 = Vector3.Distance(Letra5.transform.position, Caja16.transform.position);

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

        else if (Distancia7 < 50 && Correcto7 == false)
        {
            Letra5.transform.localScale = Caja7.transform.localScale;
            Letra5.transform.position = Caja7.transform.position;
            Correcto7 = true;
            Caja7.name = Letra5.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia8 < 50 && Correcto8 == false)
        {
            Letra5.transform.localScale = Caja8.transform.localScale;
            Letra5.transform.position = Caja8.transform.position;
            Correcto8 = true;
            Caja8.name = Letra5.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia9 < 50 && Correcto9 == false)
        {
            Letra5.transform.localScale = Caja9.transform.localScale;
            Letra5.transform.position = Caja9.transform.position;
            Correcto9 = true;
            Caja9.name = Letra5.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia10 < 50 && Correcto10 == false)
        {
            Letra5.transform.localScale = Caja10.transform.localScale;
            Letra5.transform.position = Caja10.transform.position;
            Correcto10 = true;
            Caja10.name = Letra5.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia11 < 50 && Correcto11 == false)
        {
            Letra5.transform.localScale = Caja11.transform.localScale;
            Letra5.transform.position = Caja11.transform.position;
            Correcto11 = true;
            Caja11.name = Letra5.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia12 < 50 && Correcto12 == false)
        {
            Letra5.transform.localScale = Caja12.transform.localScale;
            Letra5.transform.position = Caja12.transform.position;
            Correcto12 = true;
            Caja12.name = Letra5.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia13 < 50 && Correcto13 == false)
        {
            Letra5.transform.localScale = Caja13.transform.localScale;
            Letra5.transform.position = Caja13.transform.position;
            Correcto13 = true;
            Caja13.name = Letra5.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia14 < 50 && Correcto14 == false)
        {
            Letra5.transform.localScale = Caja14.transform.localScale;
            Letra5.transform.position = Caja14.transform.position;
            Correcto14 = true;
            Caja14.name = Letra5.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia15 < 50 && Correcto15 == false)
        {
            Letra5.transform.localScale = Caja15.transform.localScale;
            Letra5.transform.position = Caja15.transform.position;
            Correcto15 = true;
            Caja15.name = Letra5.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia16 < 50 && Correcto16 == false)
        {
            Letra5.transform.localScale = Caja16.transform.localScale;
            Letra5.transform.position = Caja16.transform.position;
            Correcto16 = true;
            Caja16.name = Letra5.name;
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
        float Distancia7 = Vector3.Distance(Letra6.transform.position, Caja7.transform.position);
        float Distancia8 = Vector3.Distance(Letra6.transform.position, Caja8.transform.position);
        float Distancia9 = Vector3.Distance(Letra6.transform.position, Caja9.transform.position);
        float Distancia10 = Vector3.Distance(Letra6.transform.position, Caja10.transform.position);
        float Distancia11 = Vector3.Distance(Letra6.transform.position, Caja11.transform.position);
        float Distancia12 = Vector3.Distance(Letra6.transform.position, Caja12.transform.position);
        float Distancia13 = Vector3.Distance(Letra6.transform.position, Caja13.transform.position);
        float Distancia14 = Vector3.Distance(Letra6.transform.position, Caja14.transform.position);
        float Distancia15 = Vector3.Distance(Letra6.transform.position, Caja15.transform.position);
        float Distancia16 = Vector3.Distance(Letra6.transform.position, Caja16.transform.position);

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

        else if (Distancia7 < 50 && Correcto7 == false)
        {
            Letra6.transform.localScale = Caja7.transform.localScale;
            Letra6.transform.position = Caja7.transform.position;
            Correcto7 = true;
            Caja7.name = Letra6.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia8 < 50 && Correcto8 == false)
        {
            Letra6.transform.localScale = Caja8.transform.localScale;
            Letra6.transform.position = Caja8.transform.position;
            Correcto8 = true;
            Caja8.name = Letra6.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia9 < 50 && Correcto9 == false)
        {
            Letra6.transform.localScale = Caja9.transform.localScale;
            Letra6.transform.position = Caja9.transform.position;
            Correcto9 = true;
            Caja9.name = Letra6.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia10 < 50 && Correcto10 == false)
        {
            Letra6.transform.localScale = Caja10.transform.localScale;
            Letra6.transform.position = Caja10.transform.position;
            Correcto10 = true;
            Caja10.name = Letra6.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia11 < 50 && Correcto11 == false)
        {
            Letra6.transform.localScale = Caja11.transform.localScale;
            Letra6.transform.position = Caja11.transform.position;
            Correcto11 = true;
            Caja11.name = Letra6.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia12 < 50 && Correcto12 == false)
        {
            Letra6.transform.localScale = Caja12.transform.localScale;
            Letra6.transform.position = Caja12.transform.position;
            Correcto12 = true;
            Caja12.name = Letra6.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia13 < 50 && Correcto13 == false)
        {
            Letra6.transform.localScale = Caja13.transform.localScale;
            Letra6.transform.position = Caja13.transform.position;
            Correcto13 = true;
            Caja13.name = Letra6.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia14 < 50 && Correcto14 == false)
        {
            Letra6.transform.localScale = Caja14.transform.localScale;
            Letra6.transform.position = Caja14.transform.position;
            Correcto14 = true;
            Caja14.name = Letra6.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia15 < 50 && Correcto15 == false)
        {
            Letra6.transform.localScale = Caja15.transform.localScale;
            Letra6.transform.position = Caja15.transform.position;
            Correcto15 = true;
            Caja15.name = Letra6.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia16 < 50 && Correcto16 == false)
        {
            Letra6.transform.localScale = Caja16.transform.localScale;
            Letra6.transform.position = Caja16.transform.position;
            Correcto16 = true;
            Caja16.name = Letra6.name;
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

    public void DropLetra7()
    {
        float Distancia1 = Vector3.Distance(Letra7.transform.position, Caja1.transform.position);
        float Distancia2 = Vector3.Distance(Letra7.transform.position, Caja2.transform.position);
        float Distancia3 = Vector3.Distance(Letra7.transform.position, Caja3.transform.position);
        float Distancia4 = Vector3.Distance(Letra7.transform.position, Caja4.transform.position);
        float Distancia5 = Vector3.Distance(Letra7.transform.position, Caja5.transform.position);
        float Distancia6 = Vector3.Distance(Letra7.transform.position, Caja6.transform.position);
        float Distancia7 = Vector3.Distance(Letra7.transform.position, Caja7.transform.position);
        float Distancia8 = Vector3.Distance(Letra7.transform.position, Caja8.transform.position);
        float Distancia9 = Vector3.Distance(Letra7.transform.position, Caja9.transform.position);
        float Distancia10 = Vector3.Distance(Letra7.transform.position, Caja10.transform.position);
        float Distancia11 = Vector3.Distance(Letra7.transform.position, Caja11.transform.position);
        float Distancia12 = Vector3.Distance(Letra7.transform.position, Caja12.transform.position);
        float Distancia13 = Vector3.Distance(Letra7.transform.position, Caja13.transform.position);
        float Distancia14 = Vector3.Distance(Letra7.transform.position, Caja14.transform.position);
        float Distancia15 = Vector3.Distance(Letra7.transform.position, Caja15.transform.position);
        float Distancia16 = Vector3.Distance(Letra7.transform.position, Caja16.transform.position);

        if (Distancia1 < 50 && Correcto1 == false)
        {
            Letra7.transform.localScale = Caja1.transform.localScale;
            Letra7.transform.position = Caja1.transform.position;
            Correcto1 = true;
            Caja1.name = Letra7.name;
            source.clip = buttonDrop;
            source.Play();


        }
        else if (Distancia2 < 50 && Correcto2 == false)
        {
            Letra7.transform.localScale = Caja2.transform.localScale;
            Letra7.transform.position = Caja2.transform.position;
            Correcto2 = true;
            Caja2.name = Letra7.name;
            source.clip = buttonDrop;
            source.Play();

        }
        else if (Distancia3 < 50 && Correcto3 == false)
        {
            Letra7.transform.localScale = Caja3.transform.localScale;
            Letra7.transform.position = Caja3.transform.position;
            Correcto3 = true;
            Caja3.name = Letra7.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distancia4 < 50 && Correcto4 == false)
        {
            Letra7.transform.localScale = Caja4.transform.localScale;
            Letra7.transform.position = Caja4.transform.position;
            Correcto4 = true;
            Caja4.name = Letra7.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia5 < 50 && Correcto5 == false)
        {
            Letra7.transform.localScale = Caja5.transform.localScale;
            Letra7.transform.position = Caja5.transform.position;
            Correcto5 = true;
            Caja5.name = Letra7.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia6 < 50 && Correcto6 == false)
        {
            Letra7.transform.localScale = Caja6.transform.localScale;
            Letra7.transform.position = Caja6.transform.position;
            Correcto6 = true;
            Caja6.name = Letra7.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia7 < 50 && Correcto7 == false)
        {
            Letra7.transform.localScale = Caja7.transform.localScale;
            Letra7.transform.position = Caja7.transform.position;
            Correcto7 = true;
            Caja7.name = Letra7.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia8 < 50 && Correcto8 == false)
        {
            Letra7.transform.localScale = Caja8.transform.localScale;
            Letra7.transform.position = Caja8.transform.position;
            Correcto8 = true;
            Caja8.name = Letra7.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia9 < 50 && Correcto9 == false)
        {
            Letra7.transform.localScale = Caja9.transform.localScale;
            Letra7.transform.position = Caja9.transform.position;
            Correcto9 = true;
            Caja9.name = Letra7.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia10 < 50 && Correcto10 == false)
        {
            Letra7.transform.localScale = Caja10.transform.localScale;
            Letra7.transform.position = Caja10.transform.position;
            Correcto10 = true;
            Caja10.name = Letra7.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia11 < 50 && Correcto11 == false)
        {
            Letra7.transform.localScale = Caja11.transform.localScale;
            Letra7.transform.position = Caja11.transform.position;
            Correcto11 = true;
            Caja11.name = Letra7.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia12 < 50 && Correcto12 == false)
        {
            Letra7.transform.localScale = Caja12.transform.localScale;
            Letra7.transform.position = Caja12.transform.position;
            Correcto12 = true;
            Caja12.name = Letra7.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia13 < 50 && Correcto13 == false)
        {
            Letra7.transform.localScale = Caja13.transform.localScale;
            Letra7.transform.position = Caja13.transform.position;
            Correcto13 = true;
            Caja13.name = Letra7.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia14 < 50 && Correcto14 == false)
        {
            Letra7.transform.localScale = Caja14.transform.localScale;
            Letra7.transform.position = Caja14.transform.position;
            Correcto14 = true;
            Caja14.name = Letra7.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia15 < 50 && Correcto15 == false)
        {
            Letra7.transform.localScale = Caja15.transform.localScale;
            Letra7.transform.position = Caja15.transform.position;
            Correcto15 = true;
            Caja15.name = Letra7.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia16 < 50 && Correcto16 == false)
        {
            Letra7.transform.localScale = Caja16.transform.localScale;
            Letra7.transform.position = Caja16.transform.position;
            Correcto16 = true;
            Caja16.name = Letra7.name;
            source.clip = buttonDrop;
            source.Play();
        }


        else
        {
            Letra7.transform.position = LetraIni7;
            source.clip = reload;
            source.Play();
        }

    }

    public void DropLetra8()
    {
        float Distancia1 = Vector3.Distance(Letra8.transform.position, Caja1.transform.position);
        float Distancia2 = Vector3.Distance(Letra8.transform.position, Caja2.transform.position);
        float Distancia3 = Vector3.Distance(Letra8.transform.position, Caja3.transform.position);
        float Distancia4 = Vector3.Distance(Letra8.transform.position, Caja4.transform.position);
        float Distancia5 = Vector3.Distance(Letra8.transform.position, Caja5.transform.position);
        float Distancia6 = Vector3.Distance(Letra8.transform.position, Caja6.transform.position);
        float Distancia7 = Vector3.Distance(Letra8.transform.position, Caja7.transform.position);
        float Distancia8 = Vector3.Distance(Letra8.transform.position, Caja8.transform.position);
        float Distancia9 = Vector3.Distance(Letra8.transform.position, Caja9.transform.position);
        float Distancia10 = Vector3.Distance(Letra8.transform.position, Caja10.transform.position);
        float Distancia11 = Vector3.Distance(Letra8.transform.position, Caja11.transform.position);
        float Distancia12 = Vector3.Distance(Letra8.transform.position, Caja12.transform.position);
        float Distancia13 = Vector3.Distance(Letra8.transform.position, Caja13.transform.position);
        float Distancia14 = Vector3.Distance(Letra8.transform.position, Caja14.transform.position);
        float Distancia15 = Vector3.Distance(Letra8.transform.position, Caja15.transform.position);
        float Distancia16 = Vector3.Distance(Letra8.transform.position, Caja16.transform.position);

        if (Distancia1 < 50 && Correcto1 == false)
        {
            Letra8.transform.localScale = Caja1.transform.localScale;
            Letra8.transform.position = Caja1.transform.position;
            Correcto1 = true;
            Caja1.name = Letra8.name;
            source.clip = buttonDrop;
            source.Play();


        }
        else if (Distancia2 < 50 && Correcto2 == false)
        {
            Letra8.transform.localScale = Caja2.transform.localScale;
            Letra8.transform.position = Caja2.transform.position;
            Correcto2 = true;
            Caja2.name = Letra8.name;
            source.clip = buttonDrop;
            source.Play();

        }
        else if (Distancia3 < 50 && Correcto3 == false)
        {
            Letra8.transform.localScale = Caja3.transform.localScale;
            Letra8.transform.position = Caja3.transform.position;
            Correcto3 = true;
            Caja3.name = Letra8.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distancia4 < 50 && Correcto4 == false)
        {
            Letra8.transform.localScale = Caja4.transform.localScale;
            Letra8.transform.position = Caja4.transform.position;
            Correcto4 = true;
            Caja4.name = Letra8.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia5 < 50 && Correcto5 == false)
        {
            Letra8.transform.localScale = Caja5.transform.localScale;
            Letra8.transform.position = Caja5.transform.position;
            Correcto5 = true;
            Caja5.name = Letra8.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia6 < 50 && Correcto6 == false)
        {
            Letra8.transform.localScale = Caja6.transform.localScale;
            Letra8.transform.position = Caja6.transform.position;
            Correcto6 = true;
            Caja6.name = Letra8.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia7 < 50 && Correcto7 == false)
        {
            Letra8.transform.localScale = Caja7.transform.localScale;
            Letra8.transform.position = Caja7.transform.position;
            Correcto7 = true;
            Caja7.name = Letra8.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia8 < 50 && Correcto8 == false)
        {
            Letra8.transform.localScale = Caja8.transform.localScale;
            Letra8.transform.position = Caja8.transform.position;
            Correcto8 = true;
            Caja8.name = Letra8.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia9 < 50 && Correcto9 == false)
        {
            Letra8.transform.localScale = Caja9.transform.localScale;
            Letra8.transform.position = Caja9.transform.position;
            Correcto9 = true;
            Caja9.name = Letra8.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia10 < 50 && Correcto10 == false)
        {
            Letra8.transform.localScale = Caja10.transform.localScale;
            Letra8.transform.position = Caja10.transform.position;
            Correcto10 = true;
            Caja10.name = Letra8.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia11 < 50 && Correcto11 == false)
        {
            Letra8.transform.localScale = Caja11.transform.localScale;
            Letra8.transform.position = Caja11.transform.position;
            Correcto11 = true;
            Caja11.name = Letra8.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia12 < 50 && Correcto12 == false)
        {
            Letra8.transform.localScale = Caja12.transform.localScale;
            Letra8.transform.position = Caja12.transform.position;
            Correcto12 = true;
            Caja12.name = Letra8.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia13 < 50 && Correcto13 == false)
        {
            Letra8.transform.localScale = Caja13.transform.localScale;
            Letra8.transform.position = Caja13.transform.position;
            Correcto13 = true;
            Caja13.name = Letra8.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia14 < 50 && Correcto14 == false)
        {
            Letra8.transform.localScale = Caja14.transform.localScale;
            Letra8.transform.position = Caja14.transform.position;
            Correcto14 = true;
            Caja14.name = Letra8.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia15 < 50 && Correcto15 == false)
        {
            Letra8.transform.localScale = Caja15.transform.localScale;
            Letra8.transform.position = Caja15.transform.position;
            Correcto15 = true;
            Caja15.name = Letra8.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia16 < 50 && Correcto16 == false)
        {
            Letra8.transform.localScale = Caja16.transform.localScale;
            Letra8.transform.position = Caja16.transform.position;
            Correcto16 = true;
            Caja16.name = Letra8.name;
            source.clip = buttonDrop;
            source.Play();
        }


        else
        {
            Letra8.transform.position = LetraIni8;
            source.clip = reload;
            source.Play();
        }

    }

    public void DropLetra9()
    {
        float Distancia1 = Vector3.Distance(Letra9.transform.position, Caja1.transform.position);
        float Distancia2 = Vector3.Distance(Letra9.transform.position, Caja2.transform.position);
        float Distancia3 = Vector3.Distance(Letra9.transform.position, Caja3.transform.position);
        float Distancia4 = Vector3.Distance(Letra9.transform.position, Caja4.transform.position);
        float Distancia5 = Vector3.Distance(Letra9.transform.position, Caja5.transform.position);
        float Distancia6 = Vector3.Distance(Letra9.transform.position, Caja6.transform.position);
        float Distancia7 = Vector3.Distance(Letra9.transform.position, Caja7.transform.position);
        float Distancia8 = Vector3.Distance(Letra9.transform.position, Caja8.transform.position);
        float Distancia9 = Vector3.Distance(Letra9.transform.position, Caja9.transform.position);
        float Distancia10 = Vector3.Distance(Letra9.transform.position, Caja10.transform.position);
        float Distancia11 = Vector3.Distance(Letra9.transform.position, Caja11.transform.position);
        float Distancia12 = Vector3.Distance(Letra9.transform.position, Caja12.transform.position);
        float Distancia13 = Vector3.Distance(Letra9.transform.position, Caja13.transform.position);
        float Distancia14 = Vector3.Distance(Letra9.transform.position, Caja14.transform.position);
        float Distancia15 = Vector3.Distance(Letra9.transform.position, Caja15.transform.position);
        float Distancia16 = Vector3.Distance(Letra9.transform.position, Caja16.transform.position);

        if (Distancia1 < 50 && Correcto1 == false)
        {
            Letra9.transform.localScale = Caja1.transform.localScale;
            Letra9.transform.position = Caja1.transform.position;
            Correcto1 = true;
            Caja1.name = Letra9.name;
            source.clip = buttonDrop;
            source.Play();


        }
        else if (Distancia2 < 50 && Correcto2 == false)
        {
            Letra9.transform.localScale = Caja2.transform.localScale;
            Letra9.transform.position = Caja2.transform.position;
            Correcto2 = true;
            Caja2.name = Letra9.name;
            source.clip = buttonDrop;
            source.Play();

        }
        else if (Distancia3 < 50 && Correcto3 == false)
        {
            Letra9.transform.localScale = Caja3.transform.localScale;
            Letra9.transform.position = Caja3.transform.position;
            Correcto3 = true;
            Caja3.name = Letra9.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distancia4 < 50 && Correcto4 == false)
        {
            Letra9.transform.localScale = Caja4.transform.localScale;
            Letra9.transform.position = Caja4.transform.position;
            Correcto4 = true;
            Caja4.name = Letra9.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia5 < 50 && Correcto5 == false)
        {
            Letra9.transform.localScale = Caja5.transform.localScale;
            Letra9.transform.position = Caja5.transform.position;
            Correcto5 = true;
            Caja5.name = Letra9.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia6 < 50 && Correcto6 == false)
        {
            Letra9.transform.localScale = Caja6.transform.localScale;
            Letra9.transform.position = Caja6.transform.position;
            Correcto6 = true;
            Caja6.name = Letra9.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia7 < 50 && Correcto7 == false)
        {
            Letra9.transform.localScale = Caja7.transform.localScale;
            Letra9.transform.position = Caja7.transform.position;
            Correcto7 = true;
            Caja7.name = Letra9.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia8 < 50 && Correcto8 == false)
        {
            Letra9.transform.localScale = Caja8.transform.localScale;
            Letra9.transform.position = Caja8.transform.position;
            Correcto8 = true;
            Caja8.name = Letra9.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia9 < 50 && Correcto9 == false)
        {
            Letra9.transform.localScale = Caja9.transform.localScale;
            Letra9.transform.position = Caja9.transform.position;
            Correcto9 = true;
            Caja9.name = Letra9.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia10 < 50 && Correcto10 == false)
        {
            Letra9.transform.localScale = Caja10.transform.localScale;
            Letra9.transform.position = Caja10.transform.position;
            Correcto10 = true;
            Caja10.name = Letra9.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia11 < 50 && Correcto11 == false)
        {
            Letra9.transform.localScale = Caja11.transform.localScale;
            Letra9.transform.position = Caja11.transform.position;
            Correcto11 = true;
            Caja11.name = Letra9.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia12 < 50 && Correcto12 == false)
        {
            Letra9.transform.localScale = Caja12.transform.localScale;
            Letra9.transform.position = Caja12.transform.position;
            Correcto12 = true;
            Caja12.name = Letra9.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia13 < 50 && Correcto13 == false)
        {
            Letra9.transform.localScale = Caja13.transform.localScale;
            Letra9.transform.position = Caja13.transform.position;
            Correcto13 = true;
            Caja13.name = Letra9.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia14 < 50 && Correcto14 == false)
        {
            Letra9.transform.localScale = Caja14.transform.localScale;
            Letra9.transform.position = Caja14.transform.position;
            Correcto14 = true;
            Caja14.name = Letra9.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia15 < 50 && Correcto15 == false)
        {
            Letra9.transform.localScale = Caja15.transform.localScale;
            Letra9.transform.position = Caja15.transform.position;
            Correcto15 = true;
            Caja15.name = Letra9.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia16 < 50 && Correcto16 == false)
        {
            Letra9.transform.localScale = Caja16.transform.localScale;
            Letra9.transform.position = Caja16.transform.position;
            Correcto16 = true;
            Caja16.name = Letra9.name;
            source.clip = buttonDrop;
            source.Play();
        }


        else
        {
            Letra9.transform.position = LetraIni9;
            source.clip = reload;
            source.Play();
        }

    }

    public void DropLetra10()
    {
        float Distancia1 = Vector3.Distance(Letra10.transform.position, Caja1.transform.position);
        float Distancia2 = Vector3.Distance(Letra10.transform.position, Caja2.transform.position);
        float Distancia3 = Vector3.Distance(Letra10.transform.position, Caja3.transform.position);
        float Distancia4 = Vector3.Distance(Letra10.transform.position, Caja4.transform.position);
        float Distancia5 = Vector3.Distance(Letra10.transform.position, Caja5.transform.position);
        float Distancia6 = Vector3.Distance(Letra10.transform.position, Caja6.transform.position);
        float Distancia7 = Vector3.Distance(Letra10.transform.position, Caja7.transform.position);
        float Distancia8 = Vector3.Distance(Letra10.transform.position, Caja8.transform.position);
        float Distancia9 = Vector3.Distance(Letra10.transform.position, Caja9.transform.position);
        float Distancia10 = Vector3.Distance(Letra10.transform.position, Caja10.transform.position);
        float Distancia11 = Vector3.Distance(Letra10.transform.position, Caja11.transform.position);
        float Distancia12 = Vector3.Distance(Letra10.transform.position, Caja12.transform.position);
        float Distancia13 = Vector3.Distance(Letra10.transform.position, Caja13.transform.position);
        float Distancia14 = Vector3.Distance(Letra10.transform.position, Caja14.transform.position);
        float Distancia15 = Vector3.Distance(Letra10.transform.position, Caja15.transform.position);
        float Distancia16 = Vector3.Distance(Letra10.transform.position, Caja16.transform.position);

        if (Distancia1 < 50 && Correcto1 == false)
        {
            Letra10.transform.localScale = Caja1.transform.localScale;
            Letra10.transform.position = Caja1.transform.position;
            Correcto1 = true;
            Caja1.name = Letra10.name;
            source.clip = buttonDrop;
            source.Play();


        }
        else if (Distancia2 < 50 && Correcto2 == false)
        {
            Letra10.transform.localScale = Caja2.transform.localScale;
            Letra10.transform.position = Caja2.transform.position;
            Correcto2 = true;
            Caja2.name = Letra10.name;
            source.clip = buttonDrop;
            source.Play();

        }
        else if (Distancia3 < 50 && Correcto3 == false)
        {
            Letra10.transform.localScale = Caja3.transform.localScale;
            Letra10.transform.position = Caja3.transform.position;
            Correcto3 = true;
            Caja3.name = Letra10.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distancia4 < 50 && Correcto4 == false)
        {
            Letra10.transform.localScale = Caja4.transform.localScale;
            Letra10.transform.position = Caja4.transform.position;
            Correcto4 = true;
            Caja4.name = Letra10.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia5 < 50 && Correcto5 == false)
        {
            Letra10.transform.localScale = Caja5.transform.localScale;
            Letra10.transform.position = Caja5.transform.position;
            Correcto5 = true;
            Caja5.name = Letra10.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia6 < 50 && Correcto6 == false)
        {
            Letra10.transform.localScale = Caja6.transform.localScale;
            Letra10.transform.position = Caja6.transform.position;
            Correcto6 = true;
            Caja6.name = Letra10.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia7 < 50 && Correcto7 == false)
        {
            Letra10.transform.localScale = Caja7.transform.localScale;
            Letra10.transform.position = Caja7.transform.position;
            Correcto7 = true;
            Caja7.name = Letra10.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia8 < 50 && Correcto8 == false)
        {
            Letra10.transform.localScale = Caja8.transform.localScale;
            Letra10.transform.position = Caja8.transform.position;
            Correcto8 = true;
            Caja8.name = Letra10.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia9 < 50 && Correcto9 == false)
        {
            Letra10.transform.localScale = Caja9.transform.localScale;
            Letra10.transform.position = Caja9.transform.position;
            Correcto9 = true;
            Caja9.name = Letra10.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia10 < 50 && Correcto10 == false)
        {
            Letra10.transform.localScale = Caja10.transform.localScale;
            Letra10.transform.position = Caja10.transform.position;
            Correcto10 = true;
            Caja10.name = Letra10.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia11 < 50 && Correcto11 == false)
        {
            Letra10.transform.localScale = Caja11.transform.localScale;
            Letra10.transform.position = Caja11.transform.position;
            Correcto11 = true;
            Caja11.name = Letra10.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia12 < 50 && Correcto12 == false)
        {
            Letra10.transform.localScale = Caja12.transform.localScale;
            Letra10.transform.position = Caja12.transform.position;
            Correcto12 = true;
            Caja12.name = Letra10.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia13 < 50 && Correcto13 == false)
        {
            Letra10.transform.localScale = Caja13.transform.localScale;
            Letra10.transform.position = Caja13.transform.position;
            Correcto13 = true;
            Caja13.name = Letra10.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia14 < 50 && Correcto14 == false)
        {
            Letra10.transform.localScale = Caja14.transform.localScale;
            Letra10.transform.position = Caja14.transform.position;
            Correcto14 = true;
            Caja14.name = Letra10.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia15 < 50 && Correcto15 == false)
        {
            Letra10.transform.localScale = Caja15.transform.localScale;
            Letra10.transform.position = Caja15.transform.position;
            Correcto15 = true;
            Caja15.name = Letra10.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia16 < 50 && Correcto16 == false)
        {
            Letra10.transform.localScale = Caja16.transform.localScale;
            Letra10.transform.position = Caja16.transform.position;
            Correcto16 = true;
            Caja16.name = Letra10.name;
            source.clip = buttonDrop;
            source.Play();
        }


        else
        {
            Letra10.transform.position = LetraIni10;
            source.clip = reload;
            source.Play();
        }

    }

    public void DropLetra11()
    {
        float Distancia1 = Vector3.Distance(Letra11.transform.position, Caja1.transform.position);
        float Distancia2 = Vector3.Distance(Letra11.transform.position, Caja2.transform.position);
        float Distancia3 = Vector3.Distance(Letra11.transform.position, Caja3.transform.position);
        float Distancia4 = Vector3.Distance(Letra11.transform.position, Caja4.transform.position);
        float Distancia5 = Vector3.Distance(Letra11.transform.position, Caja5.transform.position);
        float Distancia6 = Vector3.Distance(Letra11.transform.position, Caja6.transform.position);
        float Distancia7 = Vector3.Distance(Letra11.transform.position, Caja7.transform.position);
        float Distancia8 = Vector3.Distance(Letra11.transform.position, Caja8.transform.position);
        float Distancia9 = Vector3.Distance(Letra11.transform.position, Caja9.transform.position);
        float Distancia10 = Vector3.Distance(Letra11.transform.position, Caja10.transform.position);
        float Distancia11 = Vector3.Distance(Letra11.transform.position, Caja11.transform.position);
        float Distancia12 = Vector3.Distance(Letra11.transform.position, Caja12.transform.position);
        float Distancia13 = Vector3.Distance(Letra11.transform.position, Caja13.transform.position);
        float Distancia14 = Vector3.Distance(Letra11.transform.position, Caja14.transform.position);
        float Distancia15 = Vector3.Distance(Letra11.transform.position, Caja15.transform.position);
        float Distancia16 = Vector3.Distance(Letra11.transform.position, Caja16.transform.position);

        if (Distancia1 < 50 && Correcto1 == false)
        {
            Letra11.transform.localScale = Caja1.transform.localScale;
            Letra11.transform.position = Caja1.transform.position;
            Correcto1 = true;
            Caja1.name = Letra11.name;
            source.clip = buttonDrop;
            source.Play();


        }
        else if (Distancia2 < 50 && Correcto2 == false)
        {
            Letra11.transform.localScale = Caja2.transform.localScale;
            Letra11.transform.position = Caja2.transform.position;
            Correcto2 = true;
            Caja2.name = Letra11.name;
            source.clip = buttonDrop;
            source.Play();

        }
        else if (Distancia3 < 50 && Correcto3 == false)
        {
            Letra11.transform.localScale = Caja3.transform.localScale;
            Letra11.transform.position = Caja3.transform.position;
            Correcto3 = true;
            Caja3.name = Letra11.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distancia4 < 50 && Correcto4 == false)
        {
            Letra11.transform.localScale = Caja4.transform.localScale;
            Letra11.transform.position = Caja4.transform.position;
            Correcto4 = true;
            Caja4.name = Letra11.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia5 < 50 && Correcto5 == false)
        {
            Letra11.transform.localScale = Caja5.transform.localScale;
            Letra11.transform.position = Caja5.transform.position;
            Correcto5 = true;
            Caja5.name = Letra11.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia6 < 50 && Correcto6 == false)
        {
            Letra11.transform.localScale = Caja6.transform.localScale;
            Letra11.transform.position = Caja6.transform.position;
            Correcto6 = true;
            Caja6.name = Letra11.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia7 < 50 && Correcto7 == false)
        {
            Letra11.transform.localScale = Caja7.transform.localScale;
            Letra11.transform.position = Caja7.transform.position;
            Correcto7 = true;
            Caja7.name = Letra11.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia8 < 50 && Correcto8 == false)
        {
            Letra11.transform.localScale = Caja8.transform.localScale;
            Letra11.transform.position = Caja8.transform.position;
            Correcto8 = true;
            Caja8.name = Letra11.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia9 < 50 && Correcto9 == false)
        {
            Letra11.transform.localScale = Caja9.transform.localScale;
            Letra11.transform.position = Caja9.transform.position;
            Correcto9 = true;
            Caja9.name = Letra11.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia10 < 50 && Correcto10 == false)
        {
            Letra11.transform.localScale = Caja10.transform.localScale;
            Letra11.transform.position = Caja10.transform.position;
            Correcto10 = true;
            Caja10.name = Letra11.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia11 < 50 && Correcto11 == false)
        {
            Letra11.transform.localScale = Caja11.transform.localScale;
            Letra11.transform.position = Caja11.transform.position;
            Correcto11 = true;
            Caja11.name = Letra11.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia12 < 50 && Correcto12 == false)
        {
            Letra11.transform.localScale = Caja12.transform.localScale;
            Letra11.transform.position = Caja12.transform.position;
            Correcto12 = true;
            Caja12.name = Letra11.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia13 < 50 && Correcto13 == false)
        {
            Letra11.transform.localScale = Caja13.transform.localScale;
            Letra11.transform.position = Caja13.transform.position;
            Correcto13 = true;
            Caja13.name = Letra11.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia14 < 50 && Correcto14 == false)
        {
            Letra11.transform.localScale = Caja14.transform.localScale;
            Letra11.transform.position = Caja14.transform.position;
            Correcto14 = true;
            Caja14.name = Letra11.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia15 < 50 && Correcto15 == false)
        {
            Letra11.transform.localScale = Caja15.transform.localScale;
            Letra11.transform.position = Caja15.transform.position;
            Correcto15 = true;
            Caja15.name = Letra11.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia16 < 50 && Correcto16 == false)
        {
            Letra11.transform.localScale = Caja16.transform.localScale;
            Letra11.transform.position = Caja16.transform.position;
            Correcto16 = true;
            Caja16.name = Letra11.name;
            source.clip = buttonDrop;
            source.Play();
        }


        else
        {
            Letra11.transform.position = LetraIni11;
            source.clip = reload;
            source.Play();
        }

    }

    public void DropLetra12()
    {
        float Distancia1 = Vector3.Distance(Letra12.transform.position, Caja1.transform.position);
        float Distancia2 = Vector3.Distance(Letra12.transform.position, Caja2.transform.position);
        float Distancia3 = Vector3.Distance(Letra12.transform.position, Caja3.transform.position);
        float Distancia4 = Vector3.Distance(Letra12.transform.position, Caja4.transform.position);
        float Distancia5 = Vector3.Distance(Letra12.transform.position, Caja5.transform.position);
        float Distancia6 = Vector3.Distance(Letra12.transform.position, Caja6.transform.position);
        float Distancia7 = Vector3.Distance(Letra12.transform.position, Caja7.transform.position);
        float Distancia8 = Vector3.Distance(Letra12.transform.position, Caja8.transform.position);
        float Distancia9 = Vector3.Distance(Letra12.transform.position, Caja9.transform.position);
        float Distancia10 = Vector3.Distance(Letra12.transform.position, Caja10.transform.position);
        float Distancia11 = Vector3.Distance(Letra12.transform.position, Caja11.transform.position);
        float Distancia12 = Vector3.Distance(Letra12.transform.position, Caja12.transform.position);
        float Distancia13 = Vector3.Distance(Letra12.transform.position, Caja13.transform.position);
        float Distancia14 = Vector3.Distance(Letra12.transform.position, Caja14.transform.position);
        float Distancia15 = Vector3.Distance(Letra12.transform.position, Caja15.transform.position);
        float Distancia16 = Vector3.Distance(Letra12.transform.position, Caja16.transform.position);

        if (Distancia1 < 50 && Correcto1 == false)
        {
            Letra12.transform.localScale = Caja1.transform.localScale;
            Letra12.transform.position = Caja1.transform.position;
            Correcto1 = true;
            Caja1.name = Letra12.name;
            source.clip = buttonDrop;
            source.Play();


        }
        else if (Distancia2 < 50 && Correcto2 == false)
        {
            Letra12.transform.localScale = Caja2.transform.localScale;
            Letra12.transform.position = Caja2.transform.position;
            Correcto2 = true;
            Caja2.name = Letra12.name;
            source.clip = buttonDrop;
            source.Play();

        }
        else if (Distancia3 < 50 && Correcto3 == false)
        {
            Letra12.transform.localScale = Caja3.transform.localScale;
            Letra12.transform.position = Caja3.transform.position;
            Correcto3 = true;
            Caja3.name = Letra12.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distancia4 < 50 && Correcto4 == false)
        {
            Letra12.transform.localScale = Caja4.transform.localScale;
            Letra12.transform.position = Caja4.transform.position;
            Correcto4 = true;
            Caja4.name = Letra12.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia5 < 50 && Correcto5 == false)
        {
            Letra12.transform.localScale = Caja5.transform.localScale;
            Letra12.transform.position = Caja5.transform.position;
            Correcto5 = true;
            Caja5.name = Letra12.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia6 < 50 && Correcto6 == false)
        {
            Letra12.transform.localScale = Caja6.transform.localScale;
            Letra12.transform.position = Caja6.transform.position;
            Correcto6 = true;
            Caja6.name = Letra12.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia7 < 50 && Correcto7 == false)
        {
            Letra12.transform.localScale = Caja7.transform.localScale;
            Letra12.transform.position = Caja7.transform.position;
            Correcto7 = true;
            Caja7.name = Letra12.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia8 < 50 && Correcto8 == false)
        {
            Letra12.transform.localScale = Caja8.transform.localScale;
            Letra12.transform.position = Caja8.transform.position;
            Correcto8 = true;
            Caja8.name = Letra12.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia9 < 50 && Correcto9 == false)
        {
            Letra12.transform.localScale = Caja9.transform.localScale;
            Letra12.transform.position = Caja9.transform.position;
            Correcto9 = true;
            Caja9.name = Letra12.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia10 < 50 && Correcto10 == false)
        {
            Letra12.transform.localScale = Caja10.transform.localScale;
            Letra12.transform.position = Caja10.transform.position;
            Correcto10 = true;
            Caja10.name = Letra12.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia11 < 50 && Correcto11 == false)
        {
            Letra12.transform.localScale = Caja11.transform.localScale;
            Letra12.transform.position = Caja11.transform.position;
            Correcto11 = true;
            Caja11.name = Letra12.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia12 < 50 && Correcto12 == false)
        {
            Letra12.transform.localScale = Caja12.transform.localScale;
            Letra12.transform.position = Caja12.transform.position;
            Correcto12 = true;
            Caja12.name = Letra12.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia13 < 50 && Correcto13 == false)
        {
            Letra12.transform.localScale = Caja13.transform.localScale;
            Letra12.transform.position = Caja13.transform.position;
            Correcto13 = true;
            Caja13.name = Letra12.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia14 < 50 && Correcto14 == false)
        {
            Letra12.transform.localScale = Caja14.transform.localScale;
            Letra12.transform.position = Caja14.transform.position;
            Correcto14 = true;
            Caja14.name = Letra12.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia15 < 50 && Correcto15 == false)
        {
            Letra12.transform.localScale = Caja15.transform.localScale;
            Letra12.transform.position = Caja15.transform.position;
            Correcto15 = true;
            Caja15.name = Letra12.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia16 < 50 && Correcto16 == false)
        {
            Letra12.transform.localScale = Caja16.transform.localScale;
            Letra12.transform.position = Caja16.transform.position;
            Correcto16 = true;
            Caja16.name = Letra12.name;
            source.clip = buttonDrop;
            source.Play();
        }


        else
        {
            Letra12.transform.position = LetraIni12;
            source.clip = reload;
            source.Play();
        }

    }

    public void DropLetra13()
    {
        float Distancia1 = Vector3.Distance(Letra13.transform.position, Caja1.transform.position);
        float Distancia2 = Vector3.Distance(Letra13.transform.position, Caja2.transform.position);
        float Distancia3 = Vector3.Distance(Letra13.transform.position, Caja3.transform.position);
        float Distancia4 = Vector3.Distance(Letra13.transform.position, Caja4.transform.position);
        float Distancia5 = Vector3.Distance(Letra13.transform.position, Caja5.transform.position);
        float Distancia6 = Vector3.Distance(Letra13.transform.position, Caja6.transform.position);
        float Distancia7 = Vector3.Distance(Letra13.transform.position, Caja7.transform.position);
        float Distancia8 = Vector3.Distance(Letra13.transform.position, Caja8.transform.position);
        float Distancia9 = Vector3.Distance(Letra13.transform.position, Caja9.transform.position);
        float Distancia10 = Vector3.Distance(Letra13.transform.position, Caja10.transform.position);
        float Distancia11 = Vector3.Distance(Letra13.transform.position, Caja11.transform.position);
        float Distancia12 = Vector3.Distance(Letra13.transform.position, Caja12.transform.position);
        float Distancia13 = Vector3.Distance(Letra13.transform.position, Caja13.transform.position);
        float Distancia14 = Vector3.Distance(Letra13.transform.position, Caja14.transform.position);
        float Distancia15 = Vector3.Distance(Letra13.transform.position, Caja15.transform.position);
        float Distancia16 = Vector3.Distance(Letra13.transform.position, Caja16.transform.position);

        if (Distancia1 < 50 && Correcto1 == false)
        {
            Letra13.transform.localScale = Caja1.transform.localScale;
            Letra13.transform.position = Caja1.transform.position;
            Correcto1 = true;
            Caja1.name = Letra13.name;
            source.clip = buttonDrop;
            source.Play();


        }
        else if (Distancia2 < 50 && Correcto2 == false)
        {
            Letra13.transform.localScale = Caja2.transform.localScale;
            Letra13.transform.position = Caja2.transform.position;
            Correcto2 = true;
            Caja2.name = Letra13.name;
            source.clip = buttonDrop;
            source.Play();

        }
        else if (Distancia3 < 50 && Correcto3 == false)
        {
            Letra13.transform.localScale = Caja3.transform.localScale;
            Letra13.transform.position = Caja3.transform.position;
            Correcto3 = true;
            Caja3.name = Letra13.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distancia4 < 50 && Correcto4 == false)
        {
            Letra13.transform.localScale = Caja4.transform.localScale;
            Letra13.transform.position = Caja4.transform.position;
            Correcto4 = true;
            Caja4.name = Letra13.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia5 < 50 && Correcto5 == false)
        {
            Letra13.transform.localScale = Caja5.transform.localScale;
            Letra13.transform.position = Caja5.transform.position;
            Correcto5 = true;
            Caja5.name = Letra13.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia6 < 50 && Correcto6 == false)
        {
            Letra13.transform.localScale = Caja6.transform.localScale;
            Letra13.transform.position = Caja6.transform.position;
            Correcto6 = true;
            Caja6.name = Letra13.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia7 < 50 && Correcto7 == false)
        {
            Letra13.transform.localScale = Caja7.transform.localScale;
            Letra13.transform.position = Caja7.transform.position;
            Correcto7 = true;
            Caja7.name = Letra13.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia8 < 50 && Correcto8 == false)
        {
            Letra13.transform.localScale = Caja8.transform.localScale;
            Letra13.transform.position = Caja8.transform.position;
            Correcto8 = true;
            Caja8.name = Letra13.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia9 < 50 && Correcto9 == false)
        {
            Letra13.transform.localScale = Caja9.transform.localScale;
            Letra13.transform.position = Caja9.transform.position;
            Correcto9 = true;
            Caja9.name = Letra13.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia10 < 50 && Correcto10 == false)
        {
            Letra13.transform.localScale = Caja10.transform.localScale;
            Letra13.transform.position = Caja10.transform.position;
            Correcto10 = true;
            Caja10.name = Letra13.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia11 < 50 && Correcto11 == false)
        {
            Letra13.transform.localScale = Caja11.transform.localScale;
            Letra13.transform.position = Caja11.transform.position;
            Correcto11 = true;
            Caja11.name = Letra13.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia12 < 50 && Correcto12 == false)
        {
            Letra13.transform.localScale = Caja12.transform.localScale;
            Letra13.transform.position = Caja12.transform.position;
            Correcto12 = true;
            Caja12.name = Letra13.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia13 < 50 && Correcto13 == false)
        {
            Letra13.transform.localScale = Caja13.transform.localScale;
            Letra13.transform.position = Caja13.transform.position;
            Correcto13 = true;
            Caja13.name = Letra13.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia14 < 50 && Correcto14 == false)
        {
            Letra13.transform.localScale = Caja14.transform.localScale;
            Letra13.transform.position = Caja14.transform.position;
            Correcto14 = true;
            Caja14.name = Letra13.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia15 < 50 && Correcto15 == false)
        {
            Letra13.transform.localScale = Caja15.transform.localScale;
            Letra13.transform.position = Caja15.transform.position;
            Correcto15 = true;
            Caja15.name = Letra13.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia16 < 50 && Correcto16 == false)
        {
            Letra13.transform.localScale = Caja16.transform.localScale;
            Letra13.transform.position = Caja16.transform.position;
            Correcto16 = true;
            Caja16.name = Letra13.name;
            source.clip = buttonDrop;
            source.Play();
        }


        else
        {
            Letra13.transform.position = LetraIni13;
            source.clip = reload;
            source.Play();
        }

    }

    public void DropLetra14()
    {
        float Distancia1 = Vector3.Distance(Letra14.transform.position, Caja1.transform.position);
        float Distancia2 = Vector3.Distance(Letra14.transform.position, Caja2.transform.position);
        float Distancia3 = Vector3.Distance(Letra14.transform.position, Caja3.transform.position);
        float Distancia4 = Vector3.Distance(Letra14.transform.position, Caja4.transform.position);
        float Distancia5 = Vector3.Distance(Letra14.transform.position, Caja5.transform.position);
        float Distancia6 = Vector3.Distance(Letra14.transform.position, Caja6.transform.position);
        float Distancia7 = Vector3.Distance(Letra14.transform.position, Caja7.transform.position);
        float Distancia8 = Vector3.Distance(Letra14.transform.position, Caja8.transform.position);
        float Distancia9 = Vector3.Distance(Letra14.transform.position, Caja9.transform.position);
        float Distancia10 = Vector3.Distance(Letra14.transform.position, Caja10.transform.position);
        float Distancia11 = Vector3.Distance(Letra14.transform.position, Caja11.transform.position);
        float Distancia12 = Vector3.Distance(Letra14.transform.position, Caja12.transform.position);
        float Distancia13 = Vector3.Distance(Letra14.transform.position, Caja13.transform.position);
        float Distancia14 = Vector3.Distance(Letra14.transform.position, Caja14.transform.position);
        float Distancia15 = Vector3.Distance(Letra14.transform.position, Caja15.transform.position);
        float Distancia16 = Vector3.Distance(Letra14.transform.position, Caja16.transform.position);

        if (Distancia1 < 50 && Correcto1 == false)
        {
            Letra14.transform.localScale = Caja1.transform.localScale;
            Letra14.transform.position = Caja1.transform.position;
            Correcto1 = true;
            Caja1.name = Letra14.name;
            source.clip = buttonDrop;
            source.Play();


        }
        else if (Distancia2 < 50 && Correcto2 == false)
        {
            Letra14.transform.localScale = Caja2.transform.localScale;
            Letra14.transform.position = Caja2.transform.position;
            Correcto2 = true;
            Caja2.name = Letra14.name;
            source.clip = buttonDrop;
            source.Play();

        }
        else if (Distancia3 < 50 && Correcto3 == false)
        {
            Letra14.transform.localScale = Caja3.transform.localScale;
            Letra14.transform.position = Caja3.transform.position;
            Correcto3 = true;
            Caja3.name = Letra14.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distancia4 < 50 && Correcto4 == false)
        {
            Letra14.transform.localScale = Caja4.transform.localScale;
            Letra14.transform.position = Caja4.transform.position;
            Correcto4 = true;
            Caja4.name = Letra14.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia5 < 50 && Correcto5 == false)
        {
            Letra14.transform.localScale = Caja5.transform.localScale;
            Letra14.transform.position = Caja5.transform.position;
            Correcto5 = true;
            Caja5.name = Letra14.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia6 < 50 && Correcto6 == false)
        {
            Letra14.transform.localScale = Caja6.transform.localScale;
            Letra14.transform.position = Caja6.transform.position;
            Correcto6 = true;
            Caja6.name = Letra14.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia7 < 50 && Correcto7 == false)
        {
            Letra14.transform.localScale = Caja7.transform.localScale;
            Letra14.transform.position = Caja7.transform.position;
            Correcto7 = true;
            Caja7.name = Letra14.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia8 < 50 && Correcto8 == false)
        {
            Letra14.transform.localScale = Caja8.transform.localScale;
            Letra14.transform.position = Caja8.transform.position;
            Correcto8 = true;
            Caja8.name = Letra14.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia9 < 50 && Correcto9 == false)
        {
            Letra14.transform.localScale = Caja9.transform.localScale;
            Letra14.transform.position = Caja9.transform.position;
            Correcto9 = true;
            Caja9.name = Letra14.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia10 < 50 && Correcto10 == false)
        {
            Letra14.transform.localScale = Caja10.transform.localScale;
            Letra14.transform.position = Caja10.transform.position;
            Correcto10 = true;
            Caja10.name = Letra14.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia11 < 50 && Correcto11 == false)
        {
            Letra14.transform.localScale = Caja11.transform.localScale;
            Letra14.transform.position = Caja11.transform.position;
            Correcto11 = true;
            Caja11.name = Letra14.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia12 < 50 && Correcto12 == false)
        {
            Letra14.transform.localScale = Caja12.transform.localScale;
            Letra14.transform.position = Caja12.transform.position;
            Correcto12 = true;
            Caja12.name = Letra14.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia13 < 50 && Correcto13 == false)
        {
            Letra14.transform.localScale = Caja13.transform.localScale;
            Letra14.transform.position = Caja13.transform.position;
            Correcto13 = true;
            Caja13.name = Letra14.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia14 < 50 && Correcto14 == false)
        {
            Letra14.transform.localScale = Caja14.transform.localScale;
            Letra14.transform.position = Caja14.transform.position;
            Correcto14 = true;
            Caja14.name = Letra14.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia15 < 50 && Correcto15 == false)
        {
            Letra14.transform.localScale = Caja15.transform.localScale;
            Letra14.transform.position = Caja15.transform.position;
            Correcto15 = true;
            Caja15.name = Letra14.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia16 < 50 && Correcto16 == false)
        {
            Letra14.transform.localScale = Caja16.transform.localScale;
            Letra14.transform.position = Caja16.transform.position;
            Correcto16 = true;
            Caja16.name = Letra14.name;
            source.clip = buttonDrop;
            source.Play();
        }


        else
        {
            Letra14.transform.position = LetraIni14;
            source.clip = reload;
            source.Play();
        }

    }

    public void DropLetra15()
    {
        float Distancia1 = Vector3.Distance(Letra15.transform.position, Caja1.transform.position);
        float Distancia2 = Vector3.Distance(Letra15.transform.position, Caja2.transform.position);
        float Distancia3 = Vector3.Distance(Letra15.transform.position, Caja3.transform.position);
        float Distancia4 = Vector3.Distance(Letra15.transform.position, Caja4.transform.position);
        float Distancia5 = Vector3.Distance(Letra15.transform.position, Caja5.transform.position);
        float Distancia6 = Vector3.Distance(Letra15.transform.position, Caja6.transform.position);
        float Distancia7 = Vector3.Distance(Letra15.transform.position, Caja7.transform.position);
        float Distancia8 = Vector3.Distance(Letra15.transform.position, Caja8.transform.position);
        float Distancia9 = Vector3.Distance(Letra15.transform.position, Caja9.transform.position);
        float Distancia10 = Vector3.Distance(Letra15.transform.position, Caja10.transform.position);
        float Distancia11 = Vector3.Distance(Letra15.transform.position, Caja11.transform.position);
        float Distancia12 = Vector3.Distance(Letra15.transform.position, Caja12.transform.position);
        float Distancia13 = Vector3.Distance(Letra15.transform.position, Caja13.transform.position);
        float Distancia14 = Vector3.Distance(Letra15.transform.position, Caja14.transform.position);
        float Distancia15 = Vector3.Distance(Letra15.transform.position, Caja15.transform.position);
        float Distancia16 = Vector3.Distance(Letra15.transform.position, Caja16.transform.position);

        if (Distancia1 < 50 && Correcto1 == false)
        {
            Letra15.transform.localScale = Caja1.transform.localScale;
            Letra15.transform.position = Caja1.transform.position;
            Correcto1 = true;
            Caja1.name = Letra15.name;
            source.clip = buttonDrop;
            source.Play();


        }
        else if (Distancia2 < 50 && Correcto2 == false)
        {
            Letra15.transform.localScale = Caja2.transform.localScale;
            Letra15.transform.position = Caja2.transform.position;
            Correcto2 = true;
            Caja2.name = Letra15.name;
            source.clip = buttonDrop;
            source.Play();

        }
        else if (Distancia3 < 50 && Correcto3 == false)
        {
            Letra15.transform.localScale = Caja3.transform.localScale;
            Letra15.transform.position = Caja3.transform.position;
            Correcto3 = true;
            Caja3.name = Letra15.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distancia4 < 50 && Correcto4 == false)
        {
            Letra15.transform.localScale = Caja4.transform.localScale;
            Letra15.transform.position = Caja4.transform.position;
            Correcto4 = true;
            Caja4.name = Letra15.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia5 < 50 && Correcto5 == false)
        {
            Letra15.transform.localScale = Caja5.transform.localScale;
            Letra15.transform.position = Caja5.transform.position;
            Correcto5 = true;
            Caja5.name = Letra15.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia6 < 50 && Correcto6 == false)
        {
            Letra15.transform.localScale = Caja6.transform.localScale;
            Letra15.transform.position = Caja6.transform.position;
            Correcto6 = true;
            Caja6.name = Letra15.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia7 < 50 && Correcto7 == false)
        {
            Letra15.transform.localScale = Caja7.transform.localScale;
            Letra15.transform.position = Caja7.transform.position;
            Correcto7 = true;
            Caja7.name = Letra15.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia8 < 50 && Correcto8 == false)
        {
            Letra15.transform.localScale = Caja8.transform.localScale;
            Letra15.transform.position = Caja8.transform.position;
            Correcto8 = true;
            Caja8.name = Letra15.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia9 < 50 && Correcto9 == false)
        {
            Letra15.transform.localScale = Caja9.transform.localScale;
            Letra15.transform.position = Caja9.transform.position;
            Correcto9 = true;
            Caja9.name = Letra15.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia10 < 50 && Correcto10 == false)
        {
            Letra15.transform.localScale = Caja10.transform.localScale;
            Letra15.transform.position = Caja10.transform.position;
            Correcto10 = true;
            Caja10.name = Letra15.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia11 < 50 && Correcto11 == false)
        {
            Letra15.transform.localScale = Caja11.transform.localScale;
            Letra15.transform.position = Caja11.transform.position;
            Correcto11 = true;
            Caja11.name = Letra15.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia12 < 50 && Correcto12 == false)
        {
            Letra15.transform.localScale = Caja12.transform.localScale;
            Letra15.transform.position = Caja12.transform.position;
            Correcto12 = true;
            Caja12.name = Letra15.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia13 < 50 && Correcto13 == false)
        {
            Letra15.transform.localScale = Caja13.transform.localScale;
            Letra15.transform.position = Caja13.transform.position;
            Correcto13 = true;
            Caja13.name = Letra15.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia14 < 50 && Correcto14 == false)
        {
            Letra15.transform.localScale = Caja14.transform.localScale;
            Letra15.transform.position = Caja14.transform.position;
            Correcto14 = true;
            Caja14.name = Letra15.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia15 < 50 && Correcto15 == false)
        {
            Letra15.transform.localScale = Caja15.transform.localScale;
            Letra15.transform.position = Caja15.transform.position;
            Correcto15 = true;
            Caja15.name = Letra15.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia16 < 50 && Correcto16 == false)
        {
            Letra15.transform.localScale = Caja16.transform.localScale;
            Letra15.transform.position = Caja16.transform.position;
            Correcto16 = true;
            Caja16.name = Letra15.name;
            source.clip = buttonDrop;
            source.Play();
        }


        else
        {
            Letra15.transform.position = LetraIni15;
            source.clip = reload;
            source.Play();
        }

    }

    public void DropLetra16()
    {
        float Distancia1 = Vector3.Distance(Letra16.transform.position, Caja1.transform.position);
        float Distancia2 = Vector3.Distance(Letra16.transform.position, Caja2.transform.position);
        float Distancia3 = Vector3.Distance(Letra16.transform.position, Caja3.transform.position);
        float Distancia4 = Vector3.Distance(Letra16.transform.position, Caja4.transform.position);
        float Distancia5 = Vector3.Distance(Letra16.transform.position, Caja5.transform.position);
        float Distancia6 = Vector3.Distance(Letra16.transform.position, Caja6.transform.position);
        float Distancia7 = Vector3.Distance(Letra16.transform.position, Caja7.transform.position);
        float Distancia8 = Vector3.Distance(Letra16.transform.position, Caja8.transform.position);
        float Distancia9 = Vector3.Distance(Letra16.transform.position, Caja9.transform.position);
        float Distancia10 = Vector3.Distance(Letra16.transform.position, Caja10.transform.position);
        float Distancia11 = Vector3.Distance(Letra16.transform.position, Caja11.transform.position);
        float Distancia12 = Vector3.Distance(Letra16.transform.position, Caja12.transform.position);
        float Distancia13 = Vector3.Distance(Letra16.transform.position, Caja13.transform.position);
        float Distancia14 = Vector3.Distance(Letra16.transform.position, Caja14.transform.position);
        float Distancia15 = Vector3.Distance(Letra16.transform.position, Caja15.transform.position);
        float Distancia16 = Vector3.Distance(Letra16.transform.position, Caja16.transform.position);

        if (Distancia1 < 50 && Correcto1 == false)
        {
            Letra16.transform.localScale = Caja1.transform.localScale;
            Letra16.transform.position = Caja1.transform.position;
            Correcto1 = true;
            Caja1.name = Letra16.name;
            source.clip = buttonDrop;
            source.Play();


        }
        else if (Distancia2 < 50 && Correcto2 == false)
        {
            Letra16.transform.localScale = Caja2.transform.localScale;
            Letra16.transform.position = Caja2.transform.position;
            Correcto2 = true;
            Caja2.name = Letra16.name;
            source.clip = buttonDrop;
            source.Play();

        }
        else if (Distancia3 < 50 && Correcto3 == false)
        {
            Letra16.transform.localScale = Caja3.transform.localScale;
            Letra16.transform.position = Caja3.transform.position;
            Correcto3 = true;
            Caja3.name = Letra16.name;
            source.clip = buttonDrop;
            source.Play();
        }
        else if (Distancia4 < 50 && Correcto4 == false)
        {
            Letra16.transform.localScale = Caja4.transform.localScale;
            Letra16.transform.position = Caja4.transform.position;
            Correcto4 = true;
            Caja4.name = Letra16.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia5 < 50 && Correcto5 == false)
        {
            Letra16.transform.localScale = Caja5.transform.localScale;
            Letra16.transform.position = Caja5.transform.position;
            Correcto5 = true;
            Caja5.name = Letra16.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia6 < 50 && Correcto6 == false)
        {
            Letra16.transform.localScale = Caja6.transform.localScale;
            Letra16.transform.position = Caja6.transform.position;
            Correcto6 = true;
            Caja6.name = Letra16.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia7 < 50 && Correcto7 == false)
        {
            Letra16.transform.localScale = Caja7.transform.localScale;
            Letra16.transform.position = Caja7.transform.position;
            Correcto7 = true;
            Caja7.name = Letra16.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia8 < 50 && Correcto8 == false)
        {
            Letra16.transform.localScale = Caja8.transform.localScale;
            Letra16.transform.position = Caja8.transform.position;
            Correcto8 = true;
            Caja8.name = Letra16.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia9 < 50 && Correcto9 == false)
        {
            Letra16.transform.localScale = Caja9.transform.localScale;
            Letra16.transform.position = Caja9.transform.position;
            Correcto9 = true;
            Caja9.name = Letra16.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia10 < 50 && Correcto10 == false)
        {
            Letra16.transform.localScale = Caja10.transform.localScale;
            Letra16.transform.position = Caja10.transform.position;
            Correcto10 = true;
            Caja10.name = Letra16.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia11 < 50 && Correcto11 == false)
        {
            Letra16.transform.localScale = Caja11.transform.localScale;
            Letra16.transform.position = Caja11.transform.position;
            Correcto11 = true;
            Caja11.name = Letra16.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia12 < 50 && Correcto12 == false)
        {
            Letra16.transform.localScale = Caja12.transform.localScale;
            Letra16.transform.position = Caja12.transform.position;
            Correcto12 = true;
            Caja12.name = Letra16.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia13 < 50 && Correcto13 == false)
        {
            Letra16.transform.localScale = Caja13.transform.localScale;
            Letra16.transform.position = Caja13.transform.position;
            Correcto13 = true;
            Caja13.name = Letra16.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia14 < 50 && Correcto14 == false)
        {
            Letra16.transform.localScale = Caja14.transform.localScale;
            Letra16.transform.position = Caja14.transform.position;
            Correcto14 = true;
            Caja14.name = Letra16.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia15 < 50 && Correcto15 == false)
        {
            Letra16.transform.localScale = Caja15.transform.localScale;
            Letra16.transform.position = Caja15.transform.position;
            Correcto15 = true;
            Caja15.name = Letra16.name;
            source.clip = buttonDrop;
            source.Play();
        }

        else if (Distancia16 < 50 && Correcto16 == false)
        {
            Letra16.transform.localScale = Caja16.transform.localScale;
            Letra16.transform.position = Caja16.transform.position;
            Correcto16 = true;
            Caja16.name = Letra16.name;
            source.clip = buttonDrop;
            source.Play();
        }


        else
        {
            Letra16.transform.position = LetraIni16;
            source.clip = reload;
            source.Play();
        }

    }







    public void Check()
    {


        str = Caja1.name + Caja2.name + Caja3.name + Caja4.name + Caja5.name + Caja6.name + Caja7.name + Caja8.name + Caja9.name + Caja10.name + Caja11.name + Caja12.name + Caja13.name + Caja14.name + Caja15.name + Caja16.name;

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
        Correcto7 = false;
        Correcto8 = false;
        Correcto9 = false;
        Correcto10 = false;
        Correcto11 = false;
        Correcto12 = false;
        Correcto13 = false;
        Correcto14 = false;
        Correcto15 = false;
        Correcto16 = false;

        Caja1.name = "1";
        Caja2.name = "2";
        Caja3.name = "3";
        Caja4.name = "4";
        Caja5.name = "5";
        Caja6.name = "6";
        Caja7.name = "7";
        Caja8.name = "8";
        Caja9.name = "9";
        Caja10.name = "10";
        Caja11.name = "11";
        Caja12.name = "12";
        Caja13.name = "13";
        Caja14.name = "14";
        Caja15.name = "15";
        Caja16.name = "16";


        Letra1.transform.position = LetraIni1;
        Letra2.transform.position = LetraIni2;
        Letra3.transform.position = LetraIni3;
        Letra4.transform.position = LetraIni4;
        Letra5.transform.position = LetraIni5;
        Letra6.transform.position = LetraIni6;
        Letra7.transform.position = LetraIni7;
        Letra8.transform.position = LetraIni8;
        Letra9.transform.position = LetraIni9;
        Letra10.transform.position = LetraIni10;
        Letra11.transform.position = LetraIni11;
        Letra12.transform.position = LetraIni12;
        Letra13.transform.position = LetraIni13;
        Letra14.transform.position = LetraIni14;
        Letra15.transform.position = LetraIni15;
        Letra16.transform.position = LetraIni16;

        Letra1.transform.localScale = IniEscalaLetra1;
        Letra2.transform.localScale = IniEscalaLetra2;
        Letra3.transform.localScale = IniEscalaLetra3;
        Letra4.transform.localScale = IniEscalaLetra4;
        Letra5.transform.localScale = IniEscalaLetra5;
        Letra6.transform.localScale = IniEscalaLetra6;
        Letra7.transform.localScale = IniEscalaLetra7;
        Letra8.transform.localScale = IniEscalaLetra8;
        Letra9.transform.localScale = IniEscalaLetra9;
        Letra10.transform.localScale = IniEscalaLetra10;
        Letra11.transform.localScale = IniEscalaLetra11;
        Letra12.transform.localScale = IniEscalaLetra12;
        Letra13.transform.localScale = IniEscalaLetra13;
        Letra14.transform.localScale = IniEscalaLetra14;
        Letra15.transform.localScale = IniEscalaLetra15;
        Letra16.transform.localScale = IniEscalaLetra16;

    }

    IEnumerator LoadNextPanel()
    {
        yield return new WaitForSeconds(3f);
        questionToHide.SetActive(false);
        questionToShow.SetActive(true);
    }

}
