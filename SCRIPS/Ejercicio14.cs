using System.Collections.Generic;
using UnityEngine;

public class Ejercicio14 : MonoBehaviour
{
    List<string> objetos = new List<string>() { "totem", "ruby", "espada legendaria", "reliquia" };
    void Start()
    {
        int i = 0;
        while (i < objetos.Count)
        {
            if (objetos[i] == "espada legendaria")
                Debug.Log($" encontraste en posicion {i} ");
            //Debug.Log(objetos[i]);
            i++;
            
        }
        






    }

    // Update is called once per frame
    void Update()
    {

    }
}
