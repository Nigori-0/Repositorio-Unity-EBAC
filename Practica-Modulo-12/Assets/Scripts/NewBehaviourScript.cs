using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public List<int> miFuncion(int tamaño, int rangoInferior, int rangoSuperior)
    {
        List<int> numeros = new List<int>();

        for (int i = 0; i < tamaño; i++)
        {
            int numero = Random.Range(rangoInferior, rangoSuperior + 1);
            numeros.Add(numero);
        }

        return numeros;
    }

    
    public int[] ordenarDescendente(int[] numeros)
    {
        int[] ordenados = (int[])numeros.Clone();

        for (int i = 0; i < ordenados.Length - 1; i++)
        {
            for (int j = 0; j < ordenados.Length - 1 - i; j++)
            {
                if (ordenados[j] < ordenados[j + 1])
                {
                    int temporal = ordenados[j];
                    ordenados[j] = ordenados[j + 1];
                    ordenados[j + 1] = temporal;
                }
            }
        }

        return ordenados;
    }

    
    public HashSet<int> eliminarRepetidos(List<int> numeros)
    {
        HashSet<int> resultado = new HashSet<int>();

        foreach (int numero in numeros)
        {
            resultado.Add(numero);
        }

        return resultado;
    }

    
    public HashSet<string> eliminarRepetidosStrings(List<string> textos)
    {
        HashSet<string> resultado = new HashSet<string>();

        foreach (string texto in textos)
        {
            resultado.Add(texto);
        }

        return resultado;
    }

    public void procesarPila(Stack<string> pila)
    {
        Queue<string> cola = new Queue<string>();

        Debug.Log("Elementos de la pila:");

        while (pila.Count > 0)
        {
            string elemento = pila.Peek();

            Debug.Log("Peek de la pila: " + elemento);

            cola.Enqueue(elemento);

            Debug.Log("Pop de la pila: " + pila.Pop());
        }

        Debug.Log("Elementos de la cola:");

        while (cola.Count > 0)
        {
            Debug.Log("Peek de la cola: " + cola.Peek());

            Debug.Log("Dequeue de la cola: " + cola.Dequeue());
        }
    }

    
   
 

// Start is called before the first frame update
    void Start()
    {
        List<int> aleatorios = miFuncion(5, 1, 10);
        Debug.Log("Lista de números aleatorios:");

        foreach (int numero in aleatorios)
        {
            Debug.Log(numero);
        }


        int[] numeros = { 5, 2, 9, 1, 7 };
        int[] ordenados = ordenarDescendente(numeros);

        Debug.Log("Arreglo ordenado:");

        foreach (int numero in ordenados)
        {
            Debug.Log(numero);
        }


        List<int> repetidos = new List<int> { 2, 5, 2, 8, 5, 9 };
        HashSet<int> sinRepetidos = eliminarRepetidos(repetidos);

        Debug.Log("Lista sin repetidos:");

        foreach (int numero in sinRepetidos)
        {
            Debug.Log(numero);
        }


        Stack<string> pila = new Stack<string>();

        pila.Push("Manzana");
        pila.Push("Pera");
        pila.Push("Uva");

        procesarPila(pila);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
