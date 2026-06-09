using System.Collections.Generic;
using UnityEngine;

public class Ejercicio15 : MonoBehaviour
{
    List<string> inv = new List<string>() { "pan", "arco", "hacha", "totem","bolso" };
    void Start()
    {



        int i = 0;

        while (i < inv.Count)
        {

            print("tienes " + inv[i] + " en la casilla " + i);
           
            i++;


       
      
        }


    }

    // Update is called once per frame
    void Update()
    {

    }
}
