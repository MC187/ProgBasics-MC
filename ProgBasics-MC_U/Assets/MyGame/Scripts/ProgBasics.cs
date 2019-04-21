using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgBasics : MonoBehaviour 
{

    public int test1;
    public float test2;
    public string test3;
    public string vorname = "Marc";
    public string nachname = "Leitner";

    // Use this for initialization
    void Start () 
    {

        test1 = 1;
        Debug.Log("test 1 in Start" + test1);

        Operators();
        AddNumbers(1,2);
        MultNumbers(2, 7, 2, 2);

        Debug.Log(MyText("MC"));
        string drama = MyText("MC");
        Debug.Log("neu" + drama);



        Debug.Log(StadtLand("Salzburg", "Österreich"));

        AddZahl(2, 5);


    }



    //Operatoren HÜ 

    public void Operators()
    {
        Debug.Log("erste Tests mit Operatoren");

        Debug.Log("Multiplikative Operatoren: * " + (3 * 4));

        //Debug.Log("Multiplikative Operatoren:  / " + (3 / 4));


        Debug.Log("Additive Operatoren: + " + (5 + 5));

        Debug.Log("Relationale Operatorenn: > " + (5 > 9));

        Debug.Log("Gleichheits Operatoren: != " + (5 != 9));


        Debug.Log("Logische Operatoren: & " + (true && true));

    }



    //Void methode aufrufen
    public void XY()
    {
        // Methoden Deklaration

    }


    public void SWAG()
    {
        Debug.Log("Multiplikative Operatoren: * " + (3 * 4));
    }


    public void Methode()
    {
        Debug.Log("Gleichheits Operatoren: != " + (5 != 9));
        Debug.Log("Logische Operatoren: & " + (true && true));
    }


    public void AddNumbers(int a, int b)
    {
        int c = a + b;
        Debug.Log("add numbers " + c);

        test1 = 3;
        Debug.Log("test 1 in AddNumbers" + test1);
    }


    public void MultNumbers (float a, float b, float c, float d)
    {
        float e = a * b * c * d;
        Debug.Log(e);
    }


    public void Combine()
    {
        MultNumbers(4, 3, 2, 1);
        Operators();
    }


    public string MyText(string myName)
    {
        return "Drama" + " " + myName;
    }



    // Variabeln zuweisen Hausübung min 10 / 

    string begrususng = "hallo";  // geht nicht weil int kein string
         

    //public float MultNumbSc()
    //{
    //    float zahl1;
    //    zahl1 = 93.5f;

    //    float zahl2;
    //    zahl2 = 93.5f;

    //    Debug.Log(MultNumbSc("zahl1" + "zahl2"));

    //}


    public string StadtLand(string stadt, string land)
    {
        return "Heimat: " + stadt + ", " + land;
    }



    public void meinName()
    {
        Debug.Log("mein Name: " + vorname + " " + nachname);

    }


    public void AddZahl(int q , int w )
    {
        int r = q + w;
        Debug.Log(r);
    }
















    // Update is called once per frame
    void Update () 
    {










    }
}
