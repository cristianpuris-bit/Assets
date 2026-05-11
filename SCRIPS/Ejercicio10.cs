using System.Collections.Generic;
using UnityEngine;

public class Ejercicio10 : MonoBehaviour
{
    List<string> pociones = new List<string>() { "fuerza","debilidad","veneno","regeneracion" };
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 0;  
        while (i < pociones.Count)
        {
            Debug.Log(pociones[i]);
            i++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
