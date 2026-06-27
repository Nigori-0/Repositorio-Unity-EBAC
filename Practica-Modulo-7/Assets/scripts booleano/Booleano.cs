using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Booleano : MonoBehaviour
{
    public bool valor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        valor = !valor; 

        if (valor)
            GetComponent<Renderer>().material.color = Color.white;
        else
            GetComponent<Renderer>().material.color = Color.black;
    }
}
