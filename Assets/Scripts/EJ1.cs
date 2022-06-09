using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        escribirCadena("Mi cadena es esta");
        concatenador("Hay", 5);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            holaMundo();
        }
    }

    void holaMundo()
    {
        Debug.Log("Hola mundo");
    }

    void escribirCadena(string cadena)
    {
        Debug.Log(cadena);
    }

    void concatenador(string texto, int entero)
    {
        Debug.Log(texto + " " + entero);
    }
}
