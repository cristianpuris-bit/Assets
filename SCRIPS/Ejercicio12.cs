using System.Collections.Generic;
using UnityEngine;

public class Ejercicio12 : MonoBehaviour
{
    int[] daño = new int[4] { 20, 25, 30, 35 };
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       int i = 0;
        int valor  = 0;
        while (i < daño.Length)
        {
            Debug.Log("hiciste " + daño[i] + " en total ");
            valor += daño[i];
                  
            i++;

        }

        Debug.Log("hiciste en total de " + valor);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
