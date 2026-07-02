using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class modulo8 : MonoBehaviour
{
    int contador = 0;
    float multiplicador = 1f;

    float num1 = 10.8f;
    float num2 = 3.4f;

    int numero = 0;

    string color = "Rojo";
    // Start is called before the first frame update
    void Start()
    {
        int entero = (int)(num1 + num2);
        Debug.Log("Resultado entero: " + entero);

        float decimalNumero = 15.987654f;
        string texto = decimalNumero.ToString("F4");
        Debug.Log(texto);

        string nombreCompleto = "Juan Manuel Morales Gonzalez";

        string nombre = nombreCompleto.Substring(0, 4);
        string segundoNombre = nombreCompleto.Substring(5, 6);
        string apellido1 = nombreCompleto.Substring(12, 8);
        string apellido2 = nombreCompleto.Substring(21);

        Debug.Log(nombre);
        Debug.Log(segundoNombre);
        Debug.Log(apellido1);
        Debug.Log(apellido2);

        string[] partes = nombreCompleto.Split(' ');

        foreach (string palabra in partes)
        {
            Debug.Log(palabra);
        }
    }

    // Update is called once per frame
    void Update()
    {
        contador++;
    }
    private void FixedUpdate()
    {
        multiplicador *= 1.05f;

        numero++;

        if (numero % 2 == 0)
            GetComponent<Renderer>().material.color = Color.blue;
        else
            GetComponent<Renderer>().material.color = Color.red;

        switch (color)
        {
            case "Rojo":
                GetComponent<Renderer>().material.color = Color.red;
                break;

            case "Verde":
                GetComponent<Renderer>().material.color = Color.green;
                break;

            case "Azul":
                GetComponent<Renderer>().material.color = Color.blue;
                break;
        }
    }
}
