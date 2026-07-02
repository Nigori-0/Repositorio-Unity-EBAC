using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class modulo8_parte2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string numero1 = "2500";
        string numero2 = "4300";

        int n1, n2;

        if (int.TryParse(numero1, out n1) && int.TryParse(numero2, out n2))
        {
            int suma = n1 + n2;
            Debug.Log("Resultado de la suma: " + suma);
        }
        else
        {
            Debug.Log("Error al convertir los números.");
        }
            string oracion = "Hola Mundo";

        Debug.Log("Caracteres en índices pares:");

        for (int i = 0; i < oracion.Length; i++)
        {
            if (i % 2 == 0)
            {
                Debug.Log(oracion[i]);
            }
        }
                      
        string texto = "Hola Mundo desde Unity";
        string nuevoTexto = texto.Substring(5);

        Debug.Log("Texto sin los primeros 5 caracteres: " + nuevoTexto);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
