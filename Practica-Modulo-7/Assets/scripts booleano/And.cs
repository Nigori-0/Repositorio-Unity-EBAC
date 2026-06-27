using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class And : MonoBehaviour
{
    public Booleano go1;
    public Booleano go2;

    bool valor;
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
        valor = go1.valor && go2.valor;

        if (valor)
            GetComponent<Renderer>().material.color = Color.white;
        else
            GetComponent<Renderer>().material.color = Color.black;
    }
}
