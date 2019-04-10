using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgBasics : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
    {


        Operators();
        AddNumbers(1,2);
        MultNumbers(2, 7);


    }



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



    public void XY()
    {
        // Methoden Deklaration

    }


    //
    public void SWAG()
    {
        Debug.Log("Multiplikative Operatoren: * " + (3 * 4));
    }


    //
    public void Methode()
    {
        Debug.Log("Gleichheits Operatoren: != " + (5 != 9));
        Debug.Log("Logische Operatoren: & " + (true && true));
    }



    //
    public void AddNumbers(int a, int b)
    {
        int c = a + b;
        Debug.Log("add numbers " + c);
    }




    public void MultNumbers (float a, float b)
    {
        float d = a * b;
        Debug.Log("mult numbers " + d);
    }






    // Update is called once per frame
    void Update () 
    {










    }
}
