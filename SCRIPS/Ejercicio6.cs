using System.Collections.Generic;
using UnityEngine;

public class Ejercicio6 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    string[] enemigos = new string[4] { "goblig", "esqueleto", "zombie", "dragon" };
    void Start()
    {
        int i = 0;
        while (i < enemigos.Length)
        {
            Debug.Log(enemigos[i]);
            if (enemigos[i] == "dragon")
            {
                Debug.Log("elemento dragon se encuentra en la pocicion" + i);
                i++;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
