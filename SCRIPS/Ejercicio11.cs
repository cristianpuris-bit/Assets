using System.Collections.Generic;
using UnityEngine;

public class Ejercicio11 : MonoBehaviour
{
    int[] puntaje = new int[5] {5,10,15,20,30};
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 0;
        while (i < puntaje.Length)
        {
            Debug.Log(puntaje[i]);
            i++;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
