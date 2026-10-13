using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejerciciosestructuras : MonoBehaviour
{
    public List<int> miFuncion(int tamaño, int rangoInferior, int rangoSuperior)
    {
        List<int> numeros = new List<int>();

        for (int i = 0; i < tamaño; i++)
        {
            int numero = Random.Range(rangoInferior, rangoSuperior);
            numeros.Add(numero);
        }

        return numeros;
    }

   
    public int[] OrdenarDescendente(int[] numeros)
    {
        int[] resultado = (int[])numeros.Clone();

        System.Array.Sort(resultado);
        System.Array.Reverse(resultado);

        return resultado;
    }

   
    public HashSet<T> EliminarRepetidos<T>(List<T> elementos)
    {
        return new HashSet<T>(elementos);
    }

    
    public void ProcesarPilaYCola(Stack<string> pila)
    {
        Queue<string> cola = new Queue<string>();
        Stack<string> copia = new Stack<string>(pila);

        Debug.Log("=== CONTENIDO DE LA PILA ===");

        while (copia.Count > 0)
        {
            Debug.Log("Peek: " + copia.Peek());

            string elemento = copia.Pop();
            Debug.Log("Pop: " + elemento);

            cola.Enqueue(elemento);
        }

        Debug.Log("=== CONTENIDO DE LA COLA ===");

        while (cola.Count > 0)
        {
            Debug.Log("Peek: " + cola.Peek());

            string elemento = cola.Dequeue();
            Debug.Log("Dequeue: " + elemento);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
        List<int> aleatorios = miFuncion(5, 1, 11);
        Debug.Log("Numeros aleatorios: " + string.Join(", ", aleatorios));

        
        int[] numeros = { 8, 3, 10, 1, 5 };
        int[] ordenados = OrdenarDescendente(numeros);
        Debug.Log("Orden descendente: " + string.Join(", ", ordenados));

        List<int> repetidos = new List<int> { 1, 2, 2, 3, 3, 4 };
        HashSet<int> sinRepetidos = EliminarRepetidos(repetidos);
        Debug.Log("Sin repetidos: " + string.Join(", ", sinRepetidos));

        List<string> palabras = new List<string>
        {
            "Hola", "Unity", "Hola", "CSharp"
        };

        HashSet<string> palabrasUnicas = EliminarRepetidos(palabras);
        Debug.Log("Palabras unicas: " + string.Join(", ", palabrasUnicas));

        
        Stack<string> pila = new Stack<string>();
        pila.Push("Manzana");
        pila.Push("Pera");
        pila.Push("Uva");

        ProcesarPilaYCola(pila);
    
}

    // Update is called once per frame
    void Update()
    {
        
    }
}
