using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class modulo9 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] arr1 = new int[10];
        int[] arr2 = new int[10];
        int[] arr3 = new int[10];
     for(int i = 0; i < arr1.Length; i++)
        {
            arr1[i] = Random.Range(1, 11);
            arr2[i] = Random.Range(1, 11);
        }
     for (int i = 0; i < arr3.Length; i++)
        {
            arr3[i] = arr1[i] + arr2[i];
        }
       
        Debug.Log("Parte1");
     
     for (int i = 0; i < arr3.Length; i++)
        {
            Debug.Log(arr1[i] + " + " + arr2[i] + " = " + arr3[i]);
        }
        string[] palabras = { "hola", "mundo", "desde", "start" };
        string oracion = "";

        foreach (string laspalabras in palabras)
        {
            oracion += laspalabras + " ";
        }

        Debug.Log("parte2");
        Debug.Log(oracion);
        int[,] matriz =
       {
            {2,4},
            {3,5}
        };

        int[] vector =
        {
            6,
            7
        };

        int[] resultado = new int[2];

        for (int i = 0; i < 2; i++)
        {
            resultado[i] = 0;

            for (int j = 0; j < 2; j++)
            {
                resultado[i] += matriz[i, j] * vector[j];
            }
        }

        Debug.Log("parte3");

        for (int i = 0; i < resultado.Length; i++)
        {
            Debug.Log(resultado[i]);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
