using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Muestraeventos : MonoBehaviour
{
    public UnityEvent Mieventounity;
    public event EventHandler Cuandoesprecionado;
    // Start is called before the first frame update
    void Start()
    {
        Cuandoesprecionado += EventosEscuchando;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Cuandoesprecionado?.Invoke(this, EventArgs.Empty);
            Mieventounity.Invoke();
        }
    }
    public void EventosEscuchando(object sender, EventArgs e)
    {
        Debug.Log("el evento se escucho");
    }

    public void Eventiunitydisparo()
    {
        Debug.Log("El evento de unity se disparo bien");
    }
}
