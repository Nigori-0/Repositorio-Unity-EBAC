using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muestrasuscriptor : MonoBehaviour
{
    Muestraeventos subscriptor;
    // Start is called before the first frame update
    void Start()
    {
        subscriptor = GetComponent<Muestraeventos>();
        subscriptor.Cuandoesprecionado += Mensajeescuchadoporelsubscriptor;
    }

    private void Mensajeescuchadoporelsubscriptor(object sender, EventArgs e)
    {
        Debug.Log("El evento se escucho desde otra clase");
        subscriptor.Cuandoesprecionado -= Mensajeescuchadoporelsubscriptor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
