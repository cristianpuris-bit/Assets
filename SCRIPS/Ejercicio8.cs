using UnityEngine;

public class Ejercicio8 : MonoBehaviour
{
   int count = 0;
    void Start()
    {
        while (count > 0)
        {
            Debug.Log("tienes :" + count);
            count--;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
