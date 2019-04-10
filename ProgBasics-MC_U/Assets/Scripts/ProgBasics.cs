using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgBasics : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
    {


        Operators();



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


    // Methoden Deklaration
    public void XY()
    {
        Debug.Log()

    }


    public void SWAG()
    {
        // Do Something
    }

    public void Methode()
    {
        // Methode do something
    }








    // Update is called once per frame
    void Update () 
    {










    }
}
