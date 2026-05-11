using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class Ejercicio7 : MonoBehaviour
{

    List<string> inventario = new List<string>() { "escudo", "pocion", "arco", "vendas" };
    void Start()
    {
        int i = 0;
        while (i < inventario.Count)
        {
            Debug.Log("tiene elementos" + i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
