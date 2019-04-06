using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgBasics : MonoBehaviour {

	// Use this for initialization
	void Start () {

        Debug.Log("erste Tests mit Operatoren");


    }
	
	// Update is called once per frame
	void Update () {



        Debug.Log("Multiplikative Operatoren: * " + (3 * 4));

        //Debug.Log("Multiplikative Operatoren:  / " + (3 / 4));


        Debug.Log("Additive Operatoren: + " + (5 + 5));

        Debug.Log("Relationale Operatorenn: > " + (5 > 9));



    }
}
