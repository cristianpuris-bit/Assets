using System.Collections.Generic;
using UnityEngine;

public class Ejercicio13 : MonoBehaviour
{
    List<int> salud = new List<int>() { 0, 0, 150, 100, 200 };

    void Start()
    {
        int i = 0;

        while (i < salud.Count)
        {
            
           
            if (salud[i] > 0)
            {
                Debug.Log($" salud del enemigo {i}: {salud[i]}");
            }
            i++;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
