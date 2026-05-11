using UnityEngine;

public class Ejercicio9 : MonoBehaviour
{
    string contraseña;
    string admin;
    int intentos = 5;
    void Start()
    {
        do
        {
            Debug.Log("ingrasaste");
            Debug.Log("necesitas una contraseña");
            
        } while( intentos > 0 || contraseña == "admin");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
